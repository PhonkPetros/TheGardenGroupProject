using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDAO:DAO
    {
        public void CreateNewTicket(Ticket newTicket)
        {
            ticketCollection.InsertOne(newTicket);
        }

        public List<Ticket> GetTickets()
        {
            var filter = Builders<Ticket>.Filter.Empty;

            var projection = Builders<Ticket>.Projection.Exclude("reported_by");

            List<Ticket> tickets = ticketCollection.Find(filter).Project<Ticket>(projection).ToList();

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
        }
    }
}
