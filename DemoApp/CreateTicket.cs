using Model;
using DAL;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class CreateTicket : Form
    {
        
        private List<Ticket> sessionTickets = new List<Ticket>();
        public CreateTicket()
        {
            Ticket newSessionTicket = new Ticket();

            
            sessionTickets.Add(newSessionTicket);

            
        }

        private void CreateTicket_Load(object sender, EventArgs e)
        {
            
        }

        private void lblPriority_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Get the current session ticket
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

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            Ticket currentSessionTicket = sessionTickets.LastOrDefault();
            if (currentSessionTicket != null)
            {
                // Update the ticket with provided information
                currentSessionTicket.DateReported = dateTimePickerDateReeported.Value;
                currentSessionTicket.Subject = txtSubjectOfIncident.Text;
                currentSessionTicket.IncidentType = (IncidentType)comboBoxTypeOfIncident.SelectedIndex;
                currentSessionTicket.Priority = (Priority)comboBoxPriority.SelectedIndex;
                currentSessionTicket.Deadline = dateTimePickerDeadline.Value;
                currentSessionTicket.Description = richTxtDescription.Text;
                

                try
                {
                    // Check if the ticket is complete (e.g., required fields are filled)
                    if (!string.IsNullOrWhiteSpace(currentSessionTicket.Subject) &&
                        (currentSessionTicket.IncidentType != IncidentType.Service || currentSessionTicket.IncidentType != IncidentType.Software  || currentSessionTicket.IncidentType != IncidentType.Hardware )  &&
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
    }
}
