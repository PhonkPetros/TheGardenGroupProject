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
        private Employee newEmployee = new Employee();
        private CreateEmployeeView createEmployee;
        

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

            List<Ticket> tickets = ticketController.GetTickets(logedinEmployee);
            ticketViewControl.DisplayTickets(tickets);
            ticketViewControl.PiChartTickets(tickets);
        }

        private void dashBoardTickeUI_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Hide();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Hide();
            pnlAddUser.Hide();
            dashBoardPanel.Show();
            deleteTicketButton.Hide();
        }

        private void incidentManagamentUIbtn_Click(object sender, EventArgs e)
        {
            ticketViewPanel.Show();
            pnlAddUser.Hide();
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
            pnlAddUser.Hide();
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
            pnlAddUser.Hide();
            dashBoardPanel.Hide();
            deleteTicketButton.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            createTicket.addTicketToDatabase();
            createTicketPanel.Hide();
            ticketViewPanel.Show();
            deleteTicketButton.Hide();
            resetCreateTicketView();
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
            createTicket.addTicketToDatabase2(logedinEmployee.Id);
            createTicketPanel.Hide();
            ticketViewPanel.Show();
            deleteTicketButton.Hide();
            resetCreateTicketView();
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
            pnlAddUser.Hide();
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
            pnlAddUser.Hide();
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
            pnlAddUser.Hide();
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
            pnlAddUser.Hide();
            editTicketListView.Clear();
            deleteTicketButton.Hide();
        }
        

        private void ticketView_DoubleClick(object sender, EventArgs e)
        {
            editTicketPanel.Show();
            ticketViewPanel.Hide();
            dashBoardPanel.Hide();
            employeePanel.Hide();
            pnlAddUser.Hide();
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

        private void resetCreateTicketView()
        {
            subjectTextBox.Text = "";
            descriptionTextBox.Text = "";
            deadlineDateTimePicker.Value = DateTime.Now.AddDays(1);
            ticketDateTimePicker.Value = DateTime.Now;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e) //after click to the button in the user managment screen it dispalys add employee form
        {
            //if (!(logedinEmployee.UserType == UserType.ServiceDeskEmployee))
            //{
            //    MessageBox.Show("You don't have enough permissions to add a new employee");
            //}
            //else
            //{
                pnlCreateTicketByEmployee.Hide();
                createTicketPanel.Hide();
                dashBoardPanel.Hide();
                editTicketPanel.Hide();
                employeePanel.Hide();
                ticketViewPanel.Hide();
                pnlAddUser.ResetText();

                Clean(pnlAddUser);

                pnlAddUser.Show();
                createEmployee = new CreateEmployeeView(textBoxFirstName, textBoxLastName, comboBoxTypeOfUser, textBoxEmailAddress, textBoxPhoneNumber, textBoxLocation, textBoxPassword, newEmployee);
                createEmployee.PopulateComboBoxes();
            //}
        }

        

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            btnMoveToUserManagment_Click(sender, e);
            Clean(pnlAddUser);
        }

        private void buttonAddUser_Click(object sender, EventArgs e) //button on creating employee form panel
        {
            createEmployee.addEmployeeToDatabase();
            pnlAddUser.Hide();
            employeePanel.Show();
        }

        private void Clean(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1; //or 0
                }
            }
        }

        private void btnMoveToIncidentManagment_Click(object sender, EventArgs e)
        {
            btnIncidentManagment_Click(sender, e);
        }

        private void btnMoveToUserManagment_Click(object sender, EventArgs e)
        {
            pnlCreateTicketByEmployee.Hide();
            createTicketPanel.Hide();
            dashBoardPanel.Hide();
            editTicketPanel.Hide();
            ticketViewPanel.Hide();
            pnlAddUser.Hide();
            employeePanel.Show();
        }

        private void btnMoveToDashbord_Click(object sender, EventArgs e)
        {
            dashBoardTickeUI_Click(sender, e);
        }
    }
}
