using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoApp
{
    public partial class UserInterface : Form
    {
        private TicketView ticketViewControl;
        private TicketController ticketController;

        public UserInterface()
        {
            InitializeComponent();

            // Assuming ticketView, piChart, label, incidentChart are the actual names of controls on your form.
            ticketViewControl = new TicketView(ticketView, piChart, ticketCount, incidentChart);
            ticketController = new TicketController();
            LoadAndUpdateView();
        }

        private void loadDataToList_Click(object sender, EventArgs e)
        {
            LoadAndUpdateView();
        }

        private void LoadAndUpdateView()
        {
            List<Ticket> tickets = ticketController.GetTickets();
            ticketViewControl.DisplayTickets(tickets);
            ticketViewControl.PiChartTickets(tickets);
        }

        private void dateReportedLabel_Click(object sender, EventArgs e)
        {
        }

        private void reportedByLabel_Click(object sender, EventArgs e)
        {
            // Your code here (if needed)
        }

        private void dashBoardTickeUI_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            dashBoardPanel.Show();
        }

        private void incidentManagamentUIbtn_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Show();
            employeePanel.Hide();
            createTicketPanel.Hide();
            dashBoardPanel.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            dashBoardPanel.Show();
        }

        private void btnIncidentManagment_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Show();
            employeePanel.Hide();
            createTicketPanel.Hide();
            dashBoardPanel.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
