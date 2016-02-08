using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CMICallLog
{

    public partial class TicketDetailForm : Form
    {
        bool update;
        int updateId;
        string oldTicketNumber;
        Database db;

        bool toggled;
        int shrinkHeight;
        int expandHeight;

        public TicketDetailForm(Database db)
        {
            InitializeComponent();
            update = false;
            ticketNumBox.Text = db.GetTicketNumber();
            this.db = db;

            toggled = false;
            expandHeight = 705;
            shrinkHeight = 465;
            this.toggleMidPanel();
        }

        public TicketDetailForm(Database db, string id)
        {
            InitializeComponent();
            update = true;
            updateId = Int32.Parse(id);
            createBtn.Text = "Update";
            this.db = db;

            toggled = false;
            expandHeight = 705;
            shrinkHeight = 465;

            this.toggleMidPanel();
            this.loadCurrentData();
        }

        private void toggleMidPanel()
        {
            midPanel.Visible = toggled;
            if (toggled)
            {
                this.Height = expandHeight;
            }
            else
            {
                this.Height = shrinkHeight;
            }
        }

        private void loadCurrentData()
        {
            Dictionary<string, string> data = this.db.GetTicketInfo(this.updateId);
            ticketNumBox.Text = data["ticketNumber"].ToString();
            DateTime dc;
            if (DateTime.TryParse(data["dateCreated"].ToString(), out dc))
                createdDatePicker.Value = dc;
            else
                createdDatePicker.Value = DateTime.Today;
            createdTimeBox.Text = data["timeCreated"].ToString();
            contactTypeBox.Text = data["contactType"].ToString();
            createdByBox.Text = data["createdBy"].ToString();
            storeNumberBox.Text = data["storeNumber"].ToString();
            issueTypeBox.Text = data["issueType"].ToString();
            descriptionBox.Text = data["description"].ToString();
            oldTicketNumber = data["ticketNumber"].ToString();
            statusBox.Text = data["status"].ToString();
            priorityBox.Text = data["priority"].ToString();
            completedByBox.Text = data["completedBy"].ToString();
            DateTime dc2;
            if (DateTime.TryParse(data["dateCompleted"].ToString(), out dc2))
                dateCompletedPicker.Value = dc2;
            else
                dateCompletedPicker.Value = DateTime.Today;
            solutionBox.Text = data["solution"].ToString();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(update)
            {
                updateTicket();
            }
            else
            {
                createTicket();
            }
        }

        private void createTicket()
        {
            Dictionary<String, String> data = new Dictionary<string, string>();
            data.Add("ticketNumber", ticketNumBox.Text);
            data.Add("dateCreated", createdDatePicker.Value.ToString("MM/dd/yyyy"));
            data.Add("timeCreated", createdTimeBox.Text);
            data.Add("contactType", contactTypeBox.Text);
            data.Add("createdBy", createdByBox.Text);
            data.Add("storeNumber", storeNumberBox.Text);
            data.Add("issueType", issueTypeBox.Text);
            data.Add("status", statusBox.Text);
            data.Add("priority", priorityBox.Text);
            data.Add("description", descriptionBox.Text);
            data.Add("dateCompleted", dateCompletedPicker.Value.ToString("MM/dd/yyyy"));
            data.Add("completedBy", completedByBox.Text);
            data.Add("solution", solutionBox.Text);

            if (this.db.TicketNumberExists(data["ticketNumber"]) != null)
            {
                MessageBox.Show("Ticket number already exists in database");
                return;
            }

            this.db.InsertNewTicket(data);
            this.Close();
            DialogResult = DialogResult.Yes;
        }

        private void updateTicket()
        {
            Dictionary<String, String> data = new Dictionary<string, string>();
            data.Add("ticketNumber", ticketNumBox.Text);
            data.Add("dateCreated", createdDatePicker.Value.ToString("MM/dd/yyyy"));
            data.Add("timeCreated", createdTimeBox.Text);
            data.Add("contactType", contactTypeBox.Text);
            data.Add("createdBy", createdByBox.Text);
            data.Add("storeNumber", storeNumberBox.Text);
            data.Add("issueType", issueTypeBox.Text);
            data.Add("status", statusBox.Text);
            data.Add("priority", priorityBox.Text);
            data.Add("description", descriptionBox.Text);
            data.Add("dateCompleted", dateCompletedPicker.Value.ToString("MM/dd/yyyy"));
            data.Add("completedBy", completedByBox.Text);
            data.Add("solution", solutionBox.Text);

            if (oldTicketNumber != data["ticketNumber"] && this.db.TicketNumberExists(data["ticketNumber"]) != null)
            {
                MessageBox.Show("Ticket number already exists in database");
                return;
            }

            this.db.UpdateTicket(this.updateId, data);
            this.Close();
            DialogResult = DialogResult.Yes;
        }

        private void toggleBtn_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            this.toggleMidPanel();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Program.CopyTicketToClipboard(ticketNumBox.Text, descriptionBox.Text);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> data = new Dictionary<string, string>();
            data.Add("ticketNumber", ticketNumBox.Text);
            data.Add("dateCreated", createdDatePicker.Value.ToString("MM/dd/yyyy"));
            data.Add("timeCreated", createdTimeBox.Text);
            data.Add("contactType", contactTypeBox.Text);
            data.Add("createdBy", createdByBox.Text);
            data.Add("storeNumber", storeNumberBox.Text);
            data.Add("issueType", issueTypeBox.Text);
            data.Add("status", statusBox.Text);
            data.Add("priority", priorityBox.Text);
            data.Add("description", descriptionBox.Text);
            data.Add("dateCompleted", dateCompletedPicker.Value.ToString("MM/dd/yyyy"));
            data.Add("completedBy", completedByBox.Text);
            data.Add("solution", solutionBox.Text);

            if (this.db.TicketNumberExists(data["ticketNumber"]) != null)
            {
                MessageBox.Show("Ticket number already exists in database");
                return;
            }

            this.db.InsertNewTicket(data);

            ticketNumBox.Text = db.GetTicketNumber();
            issueTypeBox.Text = "";
            descriptionBox.Text = "";
        }

        private void filesBtn_Click(object sender, EventArgs e)
        {
            AttachedFiles frm = new AttachedFiles(db, ticketNumBox.Text);
            frm.ShowDialog(this);
        }
    }
}
