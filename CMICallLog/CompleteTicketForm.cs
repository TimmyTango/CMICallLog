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
    public partial class CompleteTicketForm : Form
    {
        int id;
        Database db;

        public CompleteTicketForm(Database db, string id)
        {
            InitializeComponent();

            this.db = db;
            this.id = Int32.Parse(id);
        }

        private void CompleteTicketForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> data = this.db.GetTicketInfoForComplete(this.id);
            ticketNumBox.Text = data["ticketNumber"].ToString();
            storeNumBox.Text = data["storeNumber"].ToString();
            descriptionBox.Text = data["description"].ToString();
            completedByBox.Text = data["completedBy"].ToString();
            solutionBox.Text = data["solution"].ToString();
            DateTime dc2;
            if (DateTime.TryParse(data["dateCompleted"].ToString(), out dc2))
                dateCompletedBox.Value = dc2;
            else
                dateCompletedBox.Value = DateTime.Today;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> data = new Dictionary<string, string>();
            data.Add("completedBy", completedByBox.Text);
            data.Add("dateCompleted", dateCompletedBox.Value.ToString("MM/dd/yyyy"));
            data.Add("solution", solutionBox.Text);
            data.Add("status", "closed");
            data.Add("ticketNumber", ticketNumBox.Text);

            this.db.MarkTicketComplete(this.id, data);
            this.Close();
            DialogResult = DialogResult.Yes;
        }

    }
}
