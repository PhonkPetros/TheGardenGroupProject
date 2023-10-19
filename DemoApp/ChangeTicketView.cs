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


        public ChangeTicketView(Ticket selectedTicket, ComboBox incidentTypeEditComboBox, ComboBox statusEditComboBox, ComboBox priorityEditComboBox, TextBox descriptionEditTextBox,DateTimePicker dateTimePickerDeadline, ListView editTicketListView)
        {
            this.selectedTicket = selectedTicket;
            this.incidentTypeEditComboBox = incidentTypeEditComboBox;
            this.statusEditComboBox = statusEditComboBox;
            this.priorityEditComboBox = priorityEditComboBox;
            this.descriptionEditTextBox = descriptionEditTextBox;
            this.deadlineEditDateTimePicker = dateTimePickerDeadline;
            this.editTicketListView = editTicketListView;
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
    }
}
