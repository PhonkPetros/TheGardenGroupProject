using DAL;
using Logic;
using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DemoApp
{
    public partial class UserInterface : Form
    {
        private TicketView ticketViewControl;
        private TicketController ticketController;
        private Employee logedinEmployee;
        private CreateTicketView createTicket;
        private ChangeTicketView changeTicket;
        DeleteTicketView deleteTicket;
        private Ticket ticket = new Ticket();

        public UserInterface(Employee employee)
        {
            InitializeComponent();

            // Assuming ticketView, piChart, label, incidentChart are the actual names of controls on your form.
            ticketViewControl = new TicketView(ticketView, piChart, ticketCount, incidentChart);
            ticketController = new TicketController();
            deleteTicketButton.Hide();

            logedinEmployee = employee;
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

        private void dashBoardTickeUI_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            dashBoardPanel.Show();
            deleteTicketButton.Hide();
        }

        private void incidentManagamentUIbtn_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Show();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            dashBoardPanel.Hide();
            deleteTicketButton.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            dashBoardPanel.Show();
            deleteTicketButton.Hide();
        }

        private void btnIncidentManagment_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Show();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            dashBoardPanel.Hide();
            deleteTicketButton.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            createTicket.addTicketToDatabase();
            createTicketPanel.Hide();
            ticketViewPanel.Show();
            deleteTicketButton.Hide();
            LoadAndUpdateView();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Show();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            dashBoardPanel.Hide();
            deleteTicketButton.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Show();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            dashBoardPanel.Hide();
            deleteTicketButton.Hide();
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            createTicket.addTicketToDatabase2();
            createTicketPanel.Hide();
            ticketViewPanel.Show();
            deleteTicketButton.Hide();
            LoadAndUpdateView();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            //define which employee is it and based on condition use methods below
            if(logedinEmployee.UserType == UserType.Employee)
            {
                ShowPanelForEmployee();
            }
            else
            {
                ShowPanelForServiceDesk();
            }
        }

        //If it is general employee
        void ShowPanelForEmployee()
        {
            ticketViewPanel.Hide();
            dashBoardPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            editTicketPanel.Hide();
            pnlCreateTicketByEmployee.Show();
            createTicket = new CreateTicketView(descriptionTextBox2, deadlineDateTimePicker2, priorityComboBox2, incidentTypeComboBox2, subjectTextBox2, ticketDateTimePicker2, ticket);
            createTicket.PopulateComboBoxes2();

        }

        //If it is service desk employee
        void ShowPanelForServiceDesk()
        {
            ticketViewPanel.Hide();
            dashBoardPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Show();
            editTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            createTicket = new CreateTicketView(descriptionTextBox, deadlineDateTimePicker, priorityComboBox, reportedByComboBox, incidentTypeComboBox, subjectTextBox, ticketDateTimePicker, ticket);
            createTicket.PopulateComboBoxes();
        }

        private void submitEditButton_Click(object sender, EventArgs e)
        {
            changeTicket.ReadChanges();
            changeTicket.ChangeTicketInDatabase();

            MessageBox.Show("Ticket was changed successfully.");

            ticketViewPanel.Show();
            dashBoardPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            editTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            editTicketListView.Clear();
            deleteTicketButton.Hide();
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            
            ticketViewPanel.Show();
            dashBoardPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            editTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            editTicketListView.Clear();
            deleteTicketButton.Hide();
        }
        

        private void ticketView_DoubleClick(object sender, EventArgs e)
        {
            editTicketPanel.Show();
            ticketViewPanel.Hide();
            dashBoardPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();

            ListViewItem selectedItem = ticketView.SelectedItems[0];
            string ticketId = selectedItem.SubItems[0].Text;
            Ticket selectedTicket = ticketController.GetTicketByTicketId(ticketId);

            changeTicket = new ChangeTicketView(selectedTicket, incidentTypeEditComboBox, statusEditComboBox, priorityEditComboBox, descriptionEditTextbox, deadlineEditDateTimePicker, editTicketListView);
            changeTicket.Initialize();
        }

        private void ticketView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(logedinEmployee.UserType == UserType.ServiceDeskEmployee)
            {
                deleteTicketButton.Show();
            }
            
        }
        private void deleteTicketButton_Click(object sender, EventArgs e)
        {
            if(ticketView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ticketView.SelectedItems[0];
                string ticketId = selectedItem.SubItems[0].Text;

                deleteTicket = new DeleteTicketView(ticketId);
                deleteTicket.DeleteTicket();
                MessageBox.Show("Ticket was successfully deleted.");
                LoadAndUpdateView();
            }
            else
            {
                MessageBox.Show("Please select a ticket to delete.");
            }
        }
    }
}
