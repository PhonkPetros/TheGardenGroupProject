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
        private List<Ticket> sessionTickets = new List<Ticket>();
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
            Ticket currentSessionTicket = sessionTickets.LastOrDefault();

            if (currentSessionTicket != null)
            {
                // Remove the session ticket
                sessionTickets.Remove(currentSessionTicket);
                MessageBox.Show("Ticket creation canceled.");
            }
            else
            {
                MessageBox.Show("No session ticket to cancel.");
            }
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            Ticket currentSessionTicket = sessionTickets.LastOrDefault();
            if (currentSessionTicket != null)
            {
                // Update the ticket with provided information
                currentSessionTicket.DateReported = dateTimePickerReported2.Value;
                currentSessionTicket.Subject = txtBoxSubject2.Text;
                currentSessionTicket.IncidentType = (IncidentType)comboBoxTypeOfIncident2.SelectedIndex;
                currentSessionTicket.Priority = (Priority)comboBoxPriority2.SelectedIndex;
                currentSessionTicket.Deadline = dateTimePickerDeadline2.Value;
                currentSessionTicket.Description = txtBoxDescription2.Text;


                try
                {
                    // Check if the ticket is complete (e.g., required fields are filled)
                    if (!string.IsNullOrWhiteSpace(currentSessionTicket.Subject) &&
                        (currentSessionTicket.IncidentType != IncidentType.Service || currentSessionTicket.IncidentType != IncidentType.Software || currentSessionTicket.IncidentType != IncidentType.Hardware) &&
                        (currentSessionTicket.Priority != Priority.Low || currentSessionTicket.Priority != Priority.Normal || currentSessionTicket.Priority != Priority.High))
                    {
                        // Add the ticket to the database
                        TicketDAO ticketDAO = new TicketDAO();
                        ticketDAO.CreateNewTicket(currentSessionTicket);
                        MessageBox.Show("Ticket added to the database.");

                        // Remove the session ticket as it's now in the database
                        sessionTickets.Remove(currentSessionTicket);

                        // Close the form
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please provide all required information.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding ticket: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No session ticket to submit.");
            }
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
            ticketViewPanel.Show();
            employeePanel.Hide();
            createTicketPanel.Hide();
            pnlCreateTicketByEmployee.Show();
            Ticket newSessionTicket = new Ticket();
            sessionTickets.Add(newSessionTicket);

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

        private void resetCreateTicketView()
        {
            subjectTextBox.Text = "";
            descriptionTextBox.Text = "";
            deadlineDateTimePicker.Value = DateTime.Now.AddDays(1);
            ticketDateTimePicker.Value = DateTime.Now;
        }
    }
}
