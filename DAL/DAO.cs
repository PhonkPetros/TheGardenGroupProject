using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;
        private IMongoDatabase database;
        protected IMongoCollection<Ticket> ticketCollection;
        protected IMongoCollection<Employee> employeeCollection;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://group2:zMwl5O2SNreD5gsE@gardengroupcluster.nu8e8ut.mongodb.net/?retryWrites=true&w=majority");
            database = client.GetDatabase("db_garden_group");
            ticketCollection = database.GetCollection<Ticket>("tickets");
            employeeCollection = database.GetCollection<Employee>("employees");

        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }
    }
}
