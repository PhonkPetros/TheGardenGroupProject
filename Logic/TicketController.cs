using System.Collections.Generic;
using Model;
using DAL;

namespace Logic
{
    public class TicketController
    {
        private readonly TicketDAO dao;

        public TicketController()
        {
            dao = new TicketDAO();
        }

        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets = dao.GetTicketsWithDeadlines();

            return tickets;
        }

        public List<Ticket> GetPastTickets()
        {
            List<Ticket> tickets = dao.GetTicketsWithPastDeadlines();

            return tickets;
        }

        public void CreateNewTicket(Ticket ticket)
        {
            dao.CreateNewTicket(ticket);
        }

        public void DeleteTicket(string ticketId)
        {
            dao.DeleteTicket(ticketId);
        }

        public Ticket GetTicketByTicketId(string ticketId)
        {
            return dao.GetTicketByTicketId(ticketId);
        }

        public void UpdateTicket(Ticket ticket)
        {
            dao.UpdateTicket(ticket);
        }
    }
}
