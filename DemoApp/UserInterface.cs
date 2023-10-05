using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoApp
{
    public partial class UserInterface : Form
    {
        private TicketView ticketViewControl; // Rename the field to avoid naming conflict
        private TicketController ticketController;

        public UserInterface()
        {
            InitializeComponent();

            ticketViewControl = new TicketView(ticketView); // Use a different name for the parameter
            ticketController = new TicketController();
        }

        private void loadDataToList_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = ticketController.GetTickets();
            ticketViewControl.DisplayTickets(tickets);
        }

        private void dateReportedLabel_Click(object sender, EventArgs e)
        {

        }

        private void reportedByLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
