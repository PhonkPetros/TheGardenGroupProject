using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DAL
{
    public class BaseDatabase
    {
        private MongoClient dbClient;
        private readonly IMongoDatabase _database;
        private const string connectionString = "mongodb+srv://group2:zMwl5O2SNreD5gsE@gardengroupcluster.nu8e8ut.mongodb.net/?retryWrites=true&w=majority";
        private const string databaseName = "db_garden_group";
        public BaseDatabase()
        {
            dbClient = new MongoClient(connectionString);
            _database = dbClient.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
