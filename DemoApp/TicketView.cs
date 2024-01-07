using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace DemoApp
{
    public class TicketView
    {
        private ListView ticketListView;
        private Chart piChart;
        private Label resolvedTicketsLabel;
        private Chart incidentChart;

        public TicketView(ListView listView, Chart chart, Label label, Chart incidentChart)
        {
            ticketListView = listView;
            piChart = chart;
            resolvedTicketsLabel = label;
            this.incidentChart = incidentChart;
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

                Colours(item, ticket);
                ticketListView.Items.Add(item);
            }
        }

        public void DisplayTicketsForIncidentManagment(List<Ticket> tickets)
        {
            ticketListView.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                if(ticket.Status == Status.SentToIncidentManagement)
                {
                    ListViewItem item = new ListViewItem(ticket.Id.ToString());
                    item.SubItems.Add(ticket.Subject);
                    item.SubItems.Add(ticket.ReportedBy.ToString());
                    item.SubItems.Add(ticket.DateReported.ToString());
                    item.SubItems.Add(ticket.Status.ToString());

                    Colours(item, ticket);
                    ticketListView.Items.Add(item);
                }
                
            }
        }

        public void Colours(ListViewItem item, Ticket ticket) 
        {
            if (ticket.Status == Status.Resolved)
            {
                item.BackColor = Color.Green;
            }
            else if (ticket.Status == Status.Open)
            {
                item.BackColor = Color.Orange;
            }
            else if (ticket.Status == Status.NoResolve)
            {
                item.ForeColor = Color.Red;
            }
            else if (ticket.Status == Status.SentToIncidentManagement)
            {
                item.ForeColor = Color.Blue;
            }
        }

        public void PiChartTickets(List<Ticket> tickets, List<Ticket> pastTickets)
        {
            int resolvedCount = 0;
            int unresolvedCount = 0;
            int pastDeadLine = 0;
            int sentToIncident = 0;
            DateTime now = DateTime.Now;


            foreach (Ticket ticket in tickets)
            {
                if ((ticket.Status == Status.NoResolve || ticket.Status == Status.SentToIncidentManagement )&& ticket.Deadline < now)
                {
                    pastDeadLine++;
                }
                else if (ticket.Status == Status.Resolved)
                {
                    resolvedCount++;
                }
                else if (ticket.Status == Status.Open)
                {
                    unresolvedCount++;
                }
                else if (ticket.Status == Status.SentToIncidentManagement)
                {
                    sentToIncident++;
                }
            }


            foreach (Ticket pastTicket in pastTickets)
            {
                if (pastTicket.Status != Status.Resolved)
                {
                    pastDeadLine++;
                }
            }

            piChart.Series["Series1"].Points.Clear();
            piChart.Series["Series1"].Points.AddXY("Resolved Tickets", resolvedCount);
            piChart.Series["Series1"].Points.AddXY("Unresolved Tickets", unresolvedCount);
            piChart.Series["Series1"].Points.AddXY("Under Incident Managment", sentToIncident);
            resolvedTicketsLabel.Text = $"{resolvedCount}/{unresolvedCount}/{sentToIncident}";

            incidentChart.Series["incidents past deadline"].Points.Clear();
            incidentChart.Series["incidents past deadline"].Points.AddXY(1, pastDeadLine);
        }

    }
}
