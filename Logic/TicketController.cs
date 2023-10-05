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
            List<Ticket> tickets = dao.GetTickets();

            return tickets;
        }

        public void CreateNewTicket(Ticket ticket)
        {
            dao.CreateNewTicket(ticket);
        }

        public void DeleteTicket(Ticket ticket)
        {
            dao.DeleteTicket(ticket);
        }
    }
}
