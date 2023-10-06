using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public class TicketView
    {

        private ListView ticketListView;

        public TicketView(ListView listView)
        {
            ticketListView = listView; 
        }
        public void DisplayTickets(List<Ticket> tickets)
        {
            ticketListView.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.ReportedBy.ToString());
                item.SubItems.Add(ticket.DateReported.ToString());
                item.SubItems.Add(ticket.Status.ToString());
                ticketListView.Items.Add(item);
            }
        }

    }
}
