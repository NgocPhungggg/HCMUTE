using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Business_Logic_Layer
{
    public class Book
    {
        DAL dal = new DAL();

        public List<BsonDocument> LoadInformation()
        {
            string filter = "{}"; // Lấy tất cả document
            string projection = "{ \"_id\": 0}"; // Ẩn MongoDB internal _id
            return dal.Find("book", filter, projection);
        }

        public bool InsertBook(
            string bookId,
            string title,
            string authorName,
            DateTime publishedYear,
            string category)
        {
            var doc = new BsonDocument
        {
            { "bookId", bookId },
            { "title", title },
            { "authorName", authorName },
            { "publishedYear", publishedYear },
            { "categoryName", category }
        };
            return dal.Insert("book", doc);
        }

        public bool UpdateBook(
            string bookId,
            string title,
            string authorName,
            DateTime publishedYear,
            string category)
        {
            var filter = new BsonDocument { { "bookId", bookId } };

            var update = Builders<BsonDocument>.Update
                .Set("title", title)
                .Set("authorName", authorName)
                .Set("publishedYear", publishedYear)
                .Set("categoryName", category);
            return dal.Update("book", filter, update);
        }

        public bool DeleteBook(string bookId)
        {
            var filter = new BsonDocument { { "bookId", bookId } };
            return dal.Delete("book", filter);
        }
        public List<BookDto> GetAll()
        {
            // Giả sử collection "book", field id là "bookId", tên sách là "title"
            var docs = dal.Find(
                collectionName: "book",
                filterString: "{}",
                projectionString: "{ bookId:1, title:1 }"
            );

            return docs.Select(d => new BookDto
            {
                BookId = d["bookId"].AsString,
                Title = d["title"].AsString
            })
            .ToList();
        }
    }
}
