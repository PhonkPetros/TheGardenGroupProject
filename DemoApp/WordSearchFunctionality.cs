using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Model;

namespace DemoApp
{
    internal class WordSearchFunctionality
    {
        TicketController ticketController = new TicketController();
        private string keywords;
        private Employee loggedInEmployee;
        public WordSearchFunctionality(Employee loggedInEmlopyee, string keywords) 
        {
            this.loggedInEmployee = loggedInEmlopyee;
            this.keywords = keywords;
        }
        
        public List<Ticket> searchTickets()
        {
            return ticketController.GetTicketsBasedOnKeywords(loggedInEmployee,keywords);
        }
    }
}
