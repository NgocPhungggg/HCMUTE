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
    public class Author
    {
        DAL dal = new DAL();
        public bool HasData()
        {
            var list = LoadInformation();
            return list != null && list.Count > 0;
        }

        public List<BsonDocument> LoadInformation()
        {
            string filter = "{}"; // Lấy tất cả document
            string projection = "{ \"_id\": 0}";
            return dal.Find("author", filter, projection);
        }

        public bool InsertAuthor(string authorId,
                                 string authorName,
                                 DateTime dateOfBirth,
                                 string nationality,
                                 string description)
        {
            var doc = new BsonDocument
        {
            { "authorId", authorId },
            { "authorName", authorName },
            { "dateOfBirth", dateOfBirth },
            { "nationality", nationality },
            { "description", description }
        };
            return dal.Insert("author", doc);
        }

        public bool UpdateAuthor(string authorId,
                                 string authorName,
                                 DateTime dateOfBirth,
                                 string nationality,
                                 string description)
        {
            var filter = new BsonDocument { { "authorId", authorId } };

            var update = Builders<BsonDocument>.Update
                .Set("authorName", authorName)
                .Set("dateOfBirth", dateOfBirth)
                .Set("nationality", nationality)
                .Set("description", description);

            return dal.Update("author", filter, update);
        }

        public bool DeleteAuthor(string authorId)
        {
            var filter = new BsonDocument { { "authorId", authorId } };
            return dal.Delete("author", filter);
        }
        public List<BsonDocument> GetBookCountPerAuthor()
        {
            var pipeline = new[]
            {
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", "$authorName" },
                    { "totalBooks", new BsonDocument("$sum", 1) }
                }),
                new BsonDocument("$sort", new BsonDocument("totalBooks", -1))
            };
            return dal.Aggregate("book", pipeline);
        }
    }
}
