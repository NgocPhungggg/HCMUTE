using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;

namespace Data_Access_Layer
{
    public class DAL
    {
        private string connectionString = "mongodb+srv://hcmutelibrary:library@clusterngocphung.i6mtwhx.mongodb.net/?retryWrites=true&w=majority&appName=ClusterNgocPhung";
        private IMongoDatabase db;
        public string name;

        public DAL()
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase("LibraryDB");
        }
        public bool CheckConnection()
        {
            try
            {
                var client = new MongoClient(connectionString);
                var dbs = client.ListDatabaseNames().ToList();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // hàm này dùng để find dữ liệu mà không có điều kiện
        public List<BsonDocument> Find(string collectionName, string filterString)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            var filter = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(filterString);
            return collection.Find(filter).ToList();
        }
        // hàm này dùng để find dữ liệu có điều kiện là ẩn vài cột
        public List<BsonDocument> Find(string collectionName, string filterString, string projectionString)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            var filter = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(filterString);
            var projection = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(projectionString);
            return collection.Find(filter).Project<BsonDocument>(projection).ToList();
        }
        // hàm này dùng để find dữ liệu có điều kiện là ẩn vài cột và theo kí tự tìm kiếm
        public List<BsonDocument> Find(string collectionName, string fieldName, string keyword, string projectionString)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Regex(fieldName, new BsonRegularExpression(keyword, "i"));
                ProjectionDefinition<BsonDocument> projection;
                if (!string.IsNullOrEmpty(projectionString))
                {
                    var bsonProjection = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(projectionString);
                    projection = new BsonDocumentProjectionDefinition<BsonDocument>(bsonProjection);
                }
                else
                {
                    projection = Builders<BsonDocument>.Projection.Exclude("_id");
                }

                return collection.Find(filter).Project<BsonDocument>(projection).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Find: " + ex.Message);
                return new List<BsonDocument>();
            }
        }

        public List<BsonDocument> Aggregate(string collectionName, PipelineDefinition<BsonDocument, BsonDocument> pipeline)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            return collection.Aggregate(pipeline).ToList();
        }
        public bool Insert(string collectionName, BsonDocument document)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                collection.InsertOne(document);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string Insert_String(string collectionName, BsonDocument document)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                collection.InsertOne(document);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public bool Update(string collectionName, BsonDocument filterDoc, UpdateDefinition<BsonDocument> updateDef)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                var result = collection.UpdateOne(filterDoc, updateDef);
                return result.ModifiedCount > 0;
            }
            catch
            {
                return false;
            }
        }
        public string Update_String(string collectionName, BsonDocument filterDoc, UpdateDefinition<BsonDocument> updateDef)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                collection.UpdateOne(filterDoc, updateDef);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool Delete(string collectionName, BsonDocument filter)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                var result = collection.DeleteOne(filter);
                return result.DeletedCount > 0;
            }
            catch
            {
                return false;
            }
        }
        public string Delete_String(string collectionName, BsonDocument filter)
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                collection.DeleteOne(filter);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

