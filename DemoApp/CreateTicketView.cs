using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Logic;
using System.Windows.Forms;
using Model.Enums;
using MongoDB.Bson;

namespace DemoApp
{
    public class CreateTicketView
    {
        TicketController ticketController = new TicketController();
        EmployeeController employeeController = new EmployeeController();
        Ticket ticket;
        TextBox descriptionTextBox;
        DateTimePicker deadlineDateTimePicker;
        ComboBox priorityComboBox;
        ComboBox reportedByComboBox;
        ComboBox incidentTypeComboBox;
        TextBox subjectTextBox;
        DateTimePicker ticketDateTimePicker;
        

        

        public CreateTicketView(TextBox descriptionTextBox, DateTimePicker deadlineDateTimePicker, ComboBox priorityComboBox, ComboBox reportedByComboBox, ComboBox incidentTypeComboBox, TextBox subjectTextBox, DateTimePicker ticketDateTimePicker, Ticket ticket) 
        { 
            this.descriptionTextBox = descriptionTextBox;
            this.deadlineDateTimePicker = deadlineDateTimePicker;
            this.priorityComboBox = priorityComboBox;
            this.reportedByComboBox = reportedByComboBox;
            this.incidentTypeComboBox = incidentTypeComboBox;
            this.subjectTextBox = subjectTextBox;
            this.ticketDateTimePicker = ticketDateTimePicker;
            this.ticket = ticket;
        }

        public CreateTicketView(TextBox descriptionTextBox, DateTimePicker deadlineDateTimePicker, ComboBox priorityComboBox, ComboBox incidentTypeComboBox, TextBox subjectTextBox, DateTimePicker ticketDateTimePicker, Ticket ticket)
        {
            this.descriptionTextBox = descriptionTextBox;
            this.deadlineDateTimePicker = deadlineDateTimePicker;
            this.priorityComboBox = priorityComboBox;
            this.incidentTypeComboBox = incidentTypeComboBox;
            this.subjectTextBox = subjectTextBox;
            this.ticketDateTimePicker = ticketDateTimePicker;
            this.ticket = ticket;
        }

        public void PopulateComboBoxes()
        {
            priorityComboBox.DataSource = Enum.GetValues(typeof(Priority));
            reportedByComboBox.DataSource = GetUserNames();
            incidentTypeComboBox.DataSource = Enum.GetValues(typeof(IncidentType));
        }

        public void PopulateComboBoxes2()
        {
            priorityComboBox.DataSource = Enum.GetValues(typeof(Priority));
            incidentTypeComboBox.DataSource = Enum.GetValues(typeof(IncidentType));
        }

        private List<string> GetUserNames()
        {
            List<Employee> employees = employeeController.GetEmployees();
            List<string> users = new List<string>();
            
            foreach (Employee employee in employees)
            {
                users.Add(employee.FullName);
            }
            return users;
        }

        private void ReadUserInput(ObjectId? id = null)
        {
            ticket.Subject = subjectTextBox.Text;
            ticket.DateReported = ticketDateTimePicker.Value;
            ticket.Deadline = deadlineDateTimePicker.Value;

            if (id.HasValue)
            {
                ticket.ReportedBy = id.ToString();
            }
            else
            {
                ticket.ReportedBy = employeeController.GetUserId(reportedByComboBox.SelectedValue.ToString());
            }

            ticket.Priority = (Priority)priorityComboBox.SelectedValue;
            ticket.Description = descriptionTextBox.Text;
            ticket.Status = Status.Open;
            ticket.IncidentType = (IncidentType)incidentTypeComboBox.SelectedValue;
        }

        public void addTicketToDatabase(ObjectId? id = null)
        {
            ReadUserInput(id);
            if (!string.IsNullOrEmpty(ticket.Subject) && !string.IsNullOrEmpty(ticket.Description))
            {
                ticketController.CreateNewTicket(ticket);
                MessageBox.Show("The ticket was successfully created.");
            }
            else
            {
                MessageBox.Show("Please fill in all fields of the form to create a ticket");
            }
        }
    }
}
