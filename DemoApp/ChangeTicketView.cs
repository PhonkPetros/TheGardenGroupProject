using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


        public ChangeTicketView(Ticket selectedTicket, ComboBox incidentTypeEditComboBox, ComboBox statusEditComboBox, ComboBox priorityEditComboBox, TextBox descriptionEditTextBox, ListView editTicketListView)
        {
            this.selectedTicket = selectedTicket;
            this.incidentTypeEditComboBox = incidentTypeEditComboBox;
            this.statusEditComboBox = statusEditComboBox;
            this.priorityEditComboBox = priorityEditComboBox;
            this.descriptionEditTextBox = descriptionEditTextBox;
            this.editTicketListView = editTicketListView;
        }

        public void Initialize()
        {
            priorityEditComboBox.DataSource = Enum.GetValues(typeof(Priority));
            incidentTypeEditComboBox.DataSource = Enum.GetValues(typeof(IncidentType));
            statusEditComboBox.DataSource = Enum.GetValues(typeof(Status));
            descriptionEditTextBox.Text = selectedTicket.Description;

            
            ListViewItem item = new ListViewItem(selectedTicket.Id.ToString());
            item.SubItems.Add(selectedTicket.Subject);
            item.SubItems.Add(selectedTicket.ReportedBy.ToString());
            item.SubItems.Add(selectedTicket.DateReported.ToString());
            item.SubItems.Add(selectedTicket.Status.ToString());
            editTicketListView.Items.Add(item);
        }
    }
}
