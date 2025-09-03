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
    public class Staff
    {
        DAL dal = new DAL();
        public List<BsonDocument> LoadInformation()
        {
            string filter = "{}"; // Lấy tất cả document
            string projection = "{ \"_id\": 0}"; ;
            return dal.Find("staff", filter, projection);
        }
        public List<BsonDocument> Search(string keyword)
        {
            string projection = "{ \"_id\": 0 }";
            return dal.Find("staff", "staffName", keyword, projection);
        }


        public string InsertStaff(string username,
                                string staffName,
                                DateTime birthdate,
                                string phone,
                                string email,
                                string address,
                                string position,
                                DateTime hiredate)
        {
            var doc = new BsonDocument
            {
                { "username", username },
                { "staffName", staffName },
                { "birthdate", birthdate },
                { "phone", phone },
                { "email", email },
                { "address", address },
                { "position", position },
                { "hiredate", hiredate }
            };
            return dal.Insert_String("staff", doc);
        }
        public string UpdateStaff(string username,
                                 string readerName,
                                 DateTime birthdate,
                                 string phone,
                                 string email,
                                 string address,
                                 string position,
                                 DateTime hiredate)
        {
            var filter = new BsonDocument { { "username", username } };

            var update = Builders<BsonDocument>.Update
                .Set("staffName", readerName)
                .Set("birthdate", birthdate)
                .Set("phone", phone)
                .Set("email", email)
                .Set("address", address)
                .Set("position", position)
                .Set("hiredate", hiredate);
            return dal.Update_String("staff", filter, update);
        }
        public string DeleteStaff(string username)
        {
            var filter = new BsonDocument { { "username", username } };
            return dal.Delete_String("staff", filter);
        }
    }
}
