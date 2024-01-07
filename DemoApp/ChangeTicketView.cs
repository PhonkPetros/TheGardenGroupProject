using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;
using Model.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DemoApp
{
    public class ChangeTicketView
    {
        private Ticket selectedTicket;
        private ComboBox incidentTypeEditComboBox;
        private ComboBox statusEditComboBox;
        private ComboBox priorityEditComboBox;
        private TextBox descriptionEditTextBox;
        private ListView editTicketListView;
        private DateTimePicker deadlineEditDateTimePicker;
        EmployeeController employeeController = new EmployeeController();
        TicketController ticketController = new TicketController();

        private UserType currentUserType; 
        private bool canChangeDeadlineStatusPriority;


        public ChangeTicketView(Ticket selectedTicket, ComboBox incidentTypeEditComboBox, ComboBox statusEditComboBox, ComboBox priorityEditComboBox, TextBox descriptionEditTextBox,DateTimePicker dateTimePickerDeadline, ListView editTicketListView, UserType currentUserType)
        {
            this.selectedTicket = selectedTicket;
            this.incidentTypeEditComboBox = incidentTypeEditComboBox;
            this.statusEditComboBox = statusEditComboBox;
            this.priorityEditComboBox = priorityEditComboBox;
            this.descriptionEditTextBox = descriptionEditTextBox;
            this.deadlineEditDateTimePicker = dateTimePickerDeadline;
            this.editTicketListView = editTicketListView;
            this.currentUserType = currentUserType;
            canChangeDeadlineStatusPriority = CanChangeDeadlineStatusPriority(selectedTicket);
            ConfigureControlsBasedOnUserType();
        }

        public void Initialize()
        {
            priorityEditComboBox.DataSource = Enum.GetValues(typeof(Priority));
            incidentTypeEditComboBox.DataSource = Enum.GetValues(typeof(IncidentType));
            statusEditComboBox.DataSource = Enum.GetValues(typeof(Status));
            priorityEditComboBox.SelectedItem = selectedTicket.Priority;
            incidentTypeEditComboBox.SelectedItem = selectedTicket.IncidentType;
            statusEditComboBox.SelectedItem = selectedTicket.Status;
            descriptionEditTextBox.Text = selectedTicket.Description;
            deadlineEditDateTimePicker.Value = selectedTicket.Deadline;

            editTicketListView.Columns.Add("ID");
            editTicketListView.Columns.Add("Subject");
            editTicketListView.Columns.Add("Reported by");
            editTicketListView.Columns.Add("Date reported");
            editTicketListView.Columns.Add("Status");

            ListViewItem item = new ListViewItem(selectedTicket.Id.ToString());
            item.SubItems.Add(selectedTicket.Subject);
            item.SubItems.Add(employeeController.GetUserName(selectedTicket.ReportedBy));
            item.SubItems.Add(selectedTicket.DateReported.ToString());
            item.SubItems.Add(selectedTicket.Status.ToString());
            editTicketListView.Items.Add(item);
        }

        public void ReadChanges()
        {
            selectedTicket.Status = (Status)statusEditComboBox.SelectedValue;
            selectedTicket.Deadline = deadlineEditDateTimePicker.Value;
            selectedTicket.Description = descriptionEditTextBox.Text;
            selectedTicket.Priority = (Priority)priorityEditComboBox.SelectedValue;
            selectedTicket.IncidentType = (IncidentType)incidentTypeEditComboBox.SelectedValue;
        }

        public void ChangeTicketInDatabase()
        {
            ticketController.UpdateTicket(selectedTicket);
        }

        private void ConfigureControlsBasedOnUserType()
        {
            // Disable or enable controls based on the user type and ticket status.
            if (currentUserType == UserType.Employee)
            {
                // Employee can change Incident Type and Description.
                // Disable controls related to Deadline, Status, and Priority.
                deadlineEditDateTimePicker.Enabled = false;
                statusEditComboBox.Enabled = false;
                priorityEditComboBox.Enabled = false;
            }
            else if (currentUserType == UserType.ServiceDeskEmployee)
            {
                // Service Employee can change all fields except Deadline, Status, and Priority
                // if the ticket status is "Sent to Incident Management."
                incidentTypeEditComboBox.Enabled = true;
                descriptionEditTextBox.Enabled = true;
                deadlineEditDateTimePicker.Enabled = true;
                statusEditComboBox.Enabled = true;
                priorityEditComboBox.Enabled = true;

                if (!canChangeDeadlineStatusPriority)
                {
                    deadlineEditDateTimePicker.Enabled = false;
                    statusEditComboBox.Enabled = false;
                    priorityEditComboBox.Enabled = false;
                }
            }
        }

        private bool CanChangeDeadlineStatusPriority(Ticket ticket)
        {
            // Logic to determine if the Deadline, Status, and Priority can be changed based on the ticket status.
            return ticket.Status != Status.SentToIncidentManagement;
        }

    }
}
