using System.Collections.Generic;
using Model;
using DAL;

namespace Logic
{
    public class TicketController
    {
        private readonly DAO dao;

        public TicketController()
        {
            dao = new DAO(); 
        }

        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets = dao.GetTickets();

            return tickets;
        }
    }
}
