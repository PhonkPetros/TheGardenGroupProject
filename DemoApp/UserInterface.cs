using DAL;
using Logic;
using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace DemoApp
{
    public partial class UserInterface : Form
    {
        private TicketView ticketViewControl;
        private TicketController ticketController;
        private Employee logedinEmployee;
        private CreateTicketView createTicket;
        private ChangeTicketView changeTicket;
        private DeleteTicketView deleteTicket;
        private WordSearchFunctionality searchFunctionality;
        private Ticket ticket = new Ticket();
        List<Panel> panels;


        public UserInterface(Employee employee)
        {
            InitializeComponent();

            ticketViewControl = new TicketView(ticketView, piChart, ticketCount, incidentChart);
            ticketController = new TicketController();
            deleteTicketButton.Hide();

            panels = new List<Panel>
            {
                ticketViewPanel, employeePanel, createTicketPanel, pnlCreateTicketByEmployee, dashBoardPanel, editTicketPanel, pnlAddUser, pnlCreateTicketByEmployee
            };

            logedinEmployee = employee;
            LoadAndUpdateView();
        }


        private void loadDataToList_Click(object sender, EventArgs e)
        {
            LoadAndUpdateView();
        }

        private void LoadAndUpdateView()
        {

            List<Ticket> tickets = ticketController.GetTickets(logedinEmployee);
            List<Ticket> pastTickets = ticketController.GetPastTickets(logedinEmployee);
            ticketViewControl.DisplayTickets(tickets);
            ticketViewControl.PiChartTickets(tickets, pastTickets);
        }

        private void switchView(Panel panel)
        {
            foreach (Panel p in panels)
            {
                if (p != panel)
                {
                    p.Hide();
                }
                else
                {
                    p.Show();
                }
                deleteTicketButton.Hide();
            }
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            createTicket.addTicketToDatabase();
            switchView(ticketViewPanel);
            resetCreateTicketView();
            LoadAndUpdateView();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            switchView(ticketViewPanel);
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            switchView(ticketViewPanel);
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            createTicket.addTicketToDatabase2(logedinEmployee.Id);
            switchView(ticketViewPanel);
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
            switchView(pnlCreateTicketByEmployee);
            createTicket = new CreateTicketView(descriptionTextBox2, deadlineDateTimePicker2, priorityComboBox2, incidentTypeComboBox2, subjectTextBox2, ticketDateTimePicker2, ticket);
            createTicket.PopulateComboBoxes2();

        }

        //If it is service desk employee
        void ShowPanelForServiceDesk()
        {
            switchView(createTicketPanel);
            createTicket = new CreateTicketView(descriptionTextBox, deadlineDateTimePicker, priorityComboBox, reportedByComboBox, incidentTypeComboBox, subjectTextBox, ticketDateTimePicker, ticket);
            createTicket.PopulateComboBoxes();
        }

        private void submitEditButton_Click(object sender, EventArgs e)
        {
            changeTicket.ReadChanges();
            changeTicket.ChangeTicketInDatabase();

            MessageBox.Show("Ticket was changed successfully.");

            switchView(ticketViewPanel);
            editTicketListView.Clear();
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            switchView(ticketViewPanel);
            editTicketListView.Clear();
        }
        

        private void ticketView_DoubleClick(object sender, EventArgs e)
        {
            switchView(editTicketPanel);

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

        private void resetCreateTicketView()
        {
            subjectTextBox.Text = "";
            descriptionTextBox.Text = "";
            deadlineDateTimePicker.Value = DateTime.Now.AddDays(1);
            ticketDateTimePicker.Value = DateTime.Now;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchView(dashBoardPanel);
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchView(ticketViewPanel);
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchView(pnlAddUser);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchbarTextBox.Text != "")
            {
                searchFunctionality = new WordSearchFunctionality(logedinEmployee,searchbarTextBox.Text);
                ticketViewControl.DisplayTickets(searchFunctionality.searchTickets());
            }
            else
            {
                LoadAndUpdateView();
            }
        }
    }
}
