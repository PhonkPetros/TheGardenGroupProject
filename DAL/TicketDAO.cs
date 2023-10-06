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

            // Define a projection to exclude the 'ReportedBy' subdocument
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
            //add query
        }
    }
}
