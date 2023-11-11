using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace DemoApp
{
    public class CloseTicketView
    {
        private string selectedTicketId;
        private TicketController ticketController = new TicketController();

        public CloseTicketView(string selectedTicketId)
        {
            this.selectedTicketId = selectedTicketId;
        }

        public void CloseTicket()
        {
            ticketController.CloseTicket(selectedTicketId);
        }
    }
}
