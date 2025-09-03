// Business_Logic_Layer/TransactionService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using Data_Access_Layer;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public class TransactionService
    {
        private readonly DAL _dal = new DAL();

        /// <summary>
        /// Lấy tất cả giao dịch, map sang DTO (không lấy _id, có bookId + readerUsername)
        /// </summary>
        public List<TransactionDto> GetAll()
        {
            // 1) Đọc trước loan để có bookId + readerUsername
            var loanDocs = _dal.Find(
                collectionName: "loan",
                filterString: "{}",
                projectionString: "{ loanId:1, readerUsername:1, bookId:1 }"
            );

            var loanMap = loanDocs.ToDictionary(
                d => d["loanId"].AsString,
                d => new {
                    ReaderUsername = d["readerUsername"].AsString,
                    BookId = d["bookId"].AsString
                }
            );

            // 2) Lấy tất cả transaction
            var txnDocs = _dal.Find(
                collectionName: "transaction",
                filterString: "{}",
                projectionString: "{ loanId:1, staffUsername:1, transactionDate:1, type:1, amount:1 }"
            );

            // 3) Map sang DTO
            return txnDocs.Select(d =>
            {
                var loanId = d["loanId"].AsString;
                var loan = loanMap.ContainsKey(loanId) ? loanMap[loanId] : null;

                return new TransactionDto
                {
                    LoanId = loanId,
                    ReaderUsername = loan?.ReaderUsername ?? "[?]",
                    BookId = loan?.BookId ?? "[?]",
                    StaffUsername = d["staffUsername"].AsString,
                    TransactionDate = d["transactionDate"].ToLocalTime(),
                    Type = d["type"].AsString,
                    Amount = Convert.ToDecimal(d["amount"].ToString())
                };
            })
            .ToList();
        }

        /// <summary>
        /// Tạo giao dịch mới
        /// </summary>
        public bool Create(string loanId,
                           string staffUsername,
                           DateTime transactionDate,
                           string type,
                           decimal amount)
        {
            var doc = new BsonDocument
            {
                { "loanId",        loanId },
                { "staffUsername", staffUsername },
                { "transactionDate", transactionDate },
                { "type",          type },
                { "amount",        amount }
            };
            return _dal.Insert("transaction", doc);
        }

        public List<BsonDocument> GetTransactionCountPerYear()
        {
            var pipeline = new[]
            {
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", new BsonDocument("$year", "$transactionDate") },
                    { "totalTransactions", new BsonDocument("$sum", 1) }
                }),
            new BsonDocument("$sort", new BsonDocument("_id", 1))
            };
            return _dal.Aggregate("transaction", pipeline);
        }
        public List<BsonDocument> GetTotalPaymentPerYear()
        {
            var pipeline = new[]
            {
                new BsonDocument("$match", new BsonDocument("type", "Payment")),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", new BsonDocument("$year", "$transactionDate") },
                    { "totalPaid", new BsonDocument("$sum", "$amount") }
                }),
                new BsonDocument("$sort", new BsonDocument("_id", 1))
            };
            return _dal.Aggregate("transaction", pipeline);
        }

    }
}
