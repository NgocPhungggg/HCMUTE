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
    public class Category
    {
        DAL dal = new DAL();
        public bool HasData()
        {
            var list = LoadInformation();
            return list != null && list.Count > 0;
        }


        public List<BsonDocument> LoadInformation()
        {
            string filter = "{}";
            string projection = "{ \"_id\": 0}";
            return dal.Find("category", filter, projection);
        }

        public bool InsertCategory(string categoryId, string categoryName, string description)
        {
            var doc = new BsonDocument
        {
            { "categoryId", categoryId },
            { "categoryName", categoryName },
            { "description", description }
        };
            return dal.Insert("category", doc);
        }

        public bool UpdateCategory(string categoryId, string categoryName, string description)
        {
            var filter = new BsonDocument { { "categoryId", categoryId } };
            var update = Builders<BsonDocument>.Update
                .Set("categoryName", categoryName)
                .Set("description", description);
            return dal.Update("category", filter, update);
        }

        public bool DeleteCategory(string categoryId)
        {
            var filter = new BsonDocument { { "categoryId", categoryId } };
            return dal.Delete("category", filter);
        }
        public List<BsonDocument> GetBookCountPerCategory()
        {
            var pipeline = new[]
            {
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", "$categoryName" },
                    { "totalBooks", new BsonDocument("$sum", 1) }
                }),
                new BsonDocument("$sort", new BsonDocument("totalBooks", -1))
            };
            return dal.Aggregate("book", pipeline);
        }

    }
}
