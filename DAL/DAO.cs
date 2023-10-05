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
        private IMongoCollection<Ticket> ticketCollection;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://group2:zMwl5O2SNreD5gsE@gardengroupcluster.nu8e8ut.mongodb.net/?retryWrites=true&w=majority");
            database = client.GetDatabase("db_garden_group");
            ticketCollection = database.GetCollection<Ticket>("tickets");

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


        public List<Ticket> GetTickets()
        {
            var filter = Builders<Ticket>.Filter.Empty;

            // Define a projection to exclude the 'ReportedBy' subdocument
            var projection = Builders<Ticket>.Projection.Exclude("reported_by");

            List<Ticket> tickets = ticketCollection.Find(filter).Project<Ticket>(projection).ToList();

            return tickets;
        }


    }


}
