using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Model;
using MongoDB.Bson;

namespace DemoApp
{
    public class DeleteTicketView
    {
        private string selectedTicketId;
        private TicketController ticketController = new TicketController();

        public DeleteTicketView(string selectedTicketId)
        {
            this.selectedTicketId = selectedTicketId;
        }

        public void DeleteTicket()
        {
            ticketController.DeleteTicket(selectedTicketId);
        }
    }
}
