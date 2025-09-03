using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using Data_Access_Layer;
using MongoDB.Driver;

namespace Business_Logic_Layer
{
    public class LoanService
    {
        private readonly DAL _dal = new DAL();

        public List<LoanDto> GetAll()
        {
            var docs = _dal.Find(
                collectionName: "loan",
                filterString: "{}",
                projectionString: "{ loanId:1, readerUsername:1, bookId:1, borrowDate:1, dueDate:1, returnDate:1, status:1 }"
            );
            return docs.Select(d => new LoanDto
            {
                LoanId = d["loanId"].AsString,
                ReaderUsername = d["readerUsername"].AsString,
                BookId = d["bookId"].AsString,
                BorrowDate = d["borrowDate"].ToLocalTime(),
                DueDate = d["dueDate"].ToLocalTime(),
                ReturnDate = d.TryGetValue("returnDate", out var rt) && !rt.IsBsonNull
                                 ? (DateTime?)rt.ToLocalTime()
                                 : null,
                Status = d["status"].AsString
            })
            .ToList();
        }

        public bool Create(string loanId,
                           string readerUsername,
                           string bookId,
                           DateTime borrowDate,
                           DateTime dueDate,
                           DateTime? returnDate,
                           string status)
        {
            var doc = new BsonDocument
            {
                { "loanId",         loanId },
                { "readerUsername", readerUsername },
                { "bookId",         bookId },
                { "borrowDate",     borrowDate },
                { "dueDate",        dueDate },
                { "status",         status }
            };
            if (returnDate.HasValue)
                doc.Add("returnDate", returnDate.Value);

            return _dal.Insert("loan", doc);
        }

        public bool Update(string loanId,
                           DateTime borrowDate,
                           DateTime dueDate,
                           DateTime? returnDate,
                           string status)
        {
            // 1) Tạo BsonDocument filter
            var filterDoc = new BsonDocument("loanId", loanId);

            // 2) Dùng Builders để tạo UpdateDefinition<BsonDocument>
            var builder = Builders<BsonDocument>.Update;
            var updateDef = builder
                                .Set("borrowDate", borrowDate)
                                .Set("dueDate", dueDate)
                                .Set("status", status);

            if (returnDate.HasValue)
            {
                updateDef = updateDef.Set("returnDate", returnDate.Value);
            }
            else
            {
                updateDef = updateDef.Unset("returnDate");
            }

            // 3) Gọi DAL.Update với đúng kiểu
            return _dal.Update("loan", filterDoc, updateDef);
        }

        public bool Delete(string loanId)
        {
            // Filter cũng phải là BsonDocument, không phải string
            var filterDoc = new BsonDocument("loanId", loanId);
            return _dal.Delete("loan", filterDoc);
        }
        public string GetNextLoanId()
        {
            // 1) Lấy về tất cả loanId
            var docs = _dal.Find(
                collectionName: "loan",
                filterString: "{}",
                projectionString: "{ loanId:1 }"
            );

            // 2) Parse phần số, tìm max
            int max = docs
                .Select(d => {
                    var s = d["loanId"].AsString;
                    if (s.Length > 1 && int.TryParse(s.Substring(1), out var n))
                        return n;
                    return 0;
                })
                .DefaultIfEmpty(0)
                .Max();

            // 3) Trả về L + (max+1) với 3 chữ số
            return $"L{(max + 1):D3}";
        }
        public List<BsonDocument> GetLoanCountByStatus()
        {
            var pipeline = new[]
            {
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", "$status" },
                    { "total", new BsonDocument("$sum", 1) }
                })
            };
            return _dal.Aggregate("loan", pipeline);
        }
    }
}
