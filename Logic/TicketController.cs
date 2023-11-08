using System.Collections.Generic;
using Model;
using DAL;
using System;
using MongoDB.Bson;

namespace Logic
{
    public class TicketController
    {
        private readonly TicketDAO dao;

        public TicketController()
        {
            dao = new TicketDAO();
        }

        public List<Ticket> GetTickets(Employee employeeId)
        {
            List<Ticket> tickets = dao.GetTicketsWithDeadlines(employeeId);

            return tickets;
        }

        public List<Ticket> GetPastTickets(Employee employeeId)
        {
            List<Ticket> tickets = dao.GetTicketsWithPastDeadlines(employeeId);

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

        public List<Ticket> GetTicketsBasedOnKeywords(Employee loggedInEmployee,string searchInput)
        {
            return dao.GetTicketsBasedOnKeywords(loggedInEmployee, searchInput);
        }
    }
}
