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
    public class Reader
    {
        DAL dal = new DAL();
        public List<BsonDocument> LoadInformation()
        {
            string filter = "{}"; // Lấy tất cả document
            string projection = "{ \"_id\": 0}";;
            return dal.Find("reader", filter, projection);
        }
        public string InsertReader(string username, 
                                   string readerName, 
                                   DateTime birthdate, 
                                   string phone, 
                                   string email, 
                                   string address, 
                                   string position)
        {
            var doc = new BsonDocument
            {
                { "username", username },
                { "readerName", readerName },
                { "birthdate", birthdate },
                { "phone", phone },
                { "email", email },
                { "address", address },
                { "position", position }
            };
            return dal.Insert_String("reader", doc);
        }
        public string UpdateReader(string username, 
                                 string readerName, 
                                 DateTime birthdate, 
                                 string phone, 
                                 string email, 
                                 string address, 
                                 string position)
        {
            var filter = new BsonDocument { { "username", username } };

            var update = Builders<BsonDocument>.Update
                .Set("readerName", readerName)
                .Set("birthdate", birthdate)
                .Set("phone", phone)
                .Set("email", email)
                .Set("address", address)
                .Set("position", position);
            return dal.Update_String("reader", filter, update);
        }
        public string DeleteReader(string username)
        {
            var filter = new BsonDocument { { "username", username } };
            return dal.Delete_String("reader", filter);
        }
        public List<ReaderDto> GetAll()
        {
            var docs = dal.Find(
              "reader",
              "{}",
              "{ username:1, readerName:1 }"
            );
            return docs.Select(d => new ReaderDto
            {
                ReaderUsername = d["username"].AsString,
                ReaderName = d["readerName"].AsString
            }).ToList();
        }

    }

}
