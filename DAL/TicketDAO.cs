using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Model;
using Model.Enums;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDAO : DAO
    {
        public void CreateNewTicket(Ticket newTicket)
        {
            ticketCollection.InsertOne(newTicket);
        }

        public List<Ticket> GetTicketsWithDeadlines()
        {
            var match = new BsonDocument
    {
        {
            "$match",
            new BsonDocument
            {
                { "deadline", new BsonDocument { { "$gt", DateTime.UtcNow } } }
            }
        }
    };

            var lookup = new BsonDocument
    {
        {
            "$lookup",
            new BsonDocument
            {
                { "from", "employees" },
                { "localField", "reported_by" },
                { "foreignField", "_id" },
                { "as", "employeeInfo" }
            }
        }
    };

            var unwind = new BsonDocument("$unwind", "$employeeInfo");

            var project = new BsonDocument
    {
        {
            "$project",
            new BsonDocument
            {
                { "id", 1 },
                { "date_reported", 1 },
                { "subject", 1 },
                { "incident_type", 1 },
                { "reported_by", "$employeeInfo.first_name" },
                { "priority", 1 },
                { "deadline", 1 },
                { "description", 1 },
                { "status", 1 }
            }
        }
    };

            var pipeline = new[] { match, lookup, unwind, project };

            List<Ticket> tickets = ticketCollection.Aggregate<Ticket>(pipeline).ToList();

            return tickets;
        }


        public List<Ticket> GetTicketsWithPastDeadlines()
        {
            var match = new BsonDocument
    {
        {
            "$match",
            new BsonDocument
            {
                { "deadline", new BsonDocument { { "$lt", DateTime.UtcNow } } }
            }
        }
    };

            var lookup = new BsonDocument
    {
        {
            "$lookup",
            new BsonDocument
            {
                { "from", "employees" },
                { "localField", "reported_by" },
                { "foreignField", "_id" },
                { "as", "employeeInfo" }
            }
        }
    };

            var unwind = new BsonDocument("$unwind", "$employeeInfo");

            var project = new BsonDocument
    {
        {
            "$project",
            new BsonDocument
            {
                { "id", 1 },
                { "date_reported", 1 },
                { "subject", 1 },
                { "incident_type", 1 },
                { "reported_by", "$employeeInfo.first_name" },
                { "priority", 1 },
                { "deadline", 1 },
                { "description", 1 },
                { "status", 1 }
            }
        }
    };

            var pipeline = new[] { match, lookup, unwind, project };

            List<Ticket> tickets = ticketCollection.Aggregate<Ticket>(pipeline).ToList();

            return tickets;
        }




        public void DeleteTicket(Ticket ticket)
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("_id", ticket.Id);
            ticketCollection.DeleteOne(filter);
        }

        public void UpdateTicket(Ticket ticket)
        {
            
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("_id", ticket.Id);
            UpdateDefinition<Ticket> update = Builders<Ticket>.Update

            .Set("subject", ticket.Subject)
            .Set("description", ticket.Description)
            .Set("deadline", ticket.Deadline)
            .Set("reported_by", ticket.ReportedBy)
            .Set("status", ticket.Status)
            .Set("priority", ticket.Priority)
            .Set("incident_type", ticket.IncidentType);

            ticketCollection.UpdateOne(filter, update);
        }

        public Ticket GetTicketByTicketId(string ticketId)
        {
            ObjectId objectId;
            if(ObjectId.TryParse(ticketId, out objectId))
            {
                FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("_id", objectId);
                return (Ticket)ticketCollection.Find(filter).First();
            }
            else
            {
                throw new Exception("there is no ticket with this id in the database");
            }
        }
    }
}
