using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Business_Logic_Layer
{

    public class Account
    {
        DAL dal = new DAL();
        public string[] CheckLogin(string username, string password)
        {
            string filter = $"{{ \"username\": \"{username}\", " +
                            $"\"password\": \"{password}\" }}";

            var result = dal.Find("account", filter);

            if (result.Count > 0)
            {
                string role = result[0]["role"].AsString;
                string status = result[0]["status"].AsString;
                return new string[] { role, status };
            }
            return null;

        }
        public List<BsonDocument> LoadInformation()
        {
            string filter = $"{{ \"username\": \"{Session.Username}\" }}";
            List<BsonDocument> result;

            if (Session.Role == "Staff")
                result = dal.Find("staff", filter);
            else
                result = dal.Find("reader", filter);

            return result;
        }
        public string CheckStatus(string username)
        {
            string filter = $"{{ \"username\": \"{username}\" }}";
            var result = dal.Find("account", filter);
            return result[0]["status"].AsString;       
        }

        public string InsertAccount(string username, 
                                    string role, 
                                    string status)
        {
            var doc = new BsonDocument
            {
                { "username", username },
                { "password", username },
                { "role", role },
                { "status", status }
            };
            return dal.Insert_String("account", doc);
        }
        public string UpdateAccount(string username,
                                    string password)
        {
            var filter = new BsonDocument { { "username", username } };

            var update = Builders<BsonDocument>.Update
                .Set("password", password);
            return dal.Update_String("account", filter, update);
        }
        public string UpdateStatus(string username,
                                 string status)
        {
            var filter = new BsonDocument { { "username", username } };

            var update = Builders<BsonDocument>.Update
                .Set("status", status);
            return dal.Update_String("account", filter, update);
        }
        public string DeleteAccount(string username)
        {
            var filter = new BsonDocument { { "username", username } };
            return dal.Delete_String("account", filter);
        }
    }
}
