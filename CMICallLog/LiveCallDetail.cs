using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMICallLog
{
    public partial class LiveCallDetail : Form
    {
        Database db;
        Incident incident;
        Update update;

        public LiveCallDetail(Database db, string storeNumber)
        {
            InitializeComponent();
            this.db = db;

            incident = new Incident();
            update = new Update(incident);

            incident.CreateDateTime = DateTime.Now;
            incident.StoreNumber = int.Parse(storeNumber);
            update.StartDateTime = DateTime.Now;
            update.EndDateTime = DateTime.Now;
            update.Type = "Helpdesk";
            update.UpdateBy = "Helpdesk";

            contactBox.Items.AddRange(Constants.ContactType);
            priorityBox.Items.AddRange(Constants.Priority);
            typeBox.Items.AddRange(Constants.ProblemType);

            BindValues();
        }

        public void BindValues()
        {
            storeList.DataBindings.Clear();
            callerText.DataBindings.Clear();
            contactBox.DataBindings.Clear();
            priorityBox.DataBindings.Clear();
            startDateBox.DataBindings.Clear();
            endDateBox.DataBindings.Clear();
            typeBox.DataBindings.Clear();
            manualBox.DataBindings.Clear();
            problemText.DataBindings.Clear();
            resolutionText.DataBindings.Clear();

            storeList.DataBindings.Add("Text", incident, "StoreNumber");
            callerText.DataBindings.Add("Text", incident, "ContactName");
            contactBox.DataBindings.Add("Text", incident, "ContactType");
            priorityBox.DataBindings.Add("Text", incident, "Priority");
            startDateBox.DataBindings.Add("Value", update, "StartDateTime");
            endDateBox.DataBindings.Add("Value", update, "EndDateTime");
            typeBox.DataBindings.Add("Text", incident, "ProblemType");
            manualBox.DataBindings.Add("Checked", incident, "PosManual");
            problemText.DataBindings.Add("Text", incident, "Problem");
            resolutionText.DataBindings.Add("Text", update, "Description");
        }        

        private void nowBtn_Click(object sender, EventArgs e)
        {
            endDateBox.Value = DateTime.Now;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            incident.CreateDateTime = update.StartDateTime;
            incident.Status = "closed";
            update.Status = "closed";

            db.CreateIncident(incident);
            db.CreateUpdate(update);

            EmailSender.SendIncidentEmail(db, incident);
            EmailSender.SendUpdateEmail(db, update);

            this.Close();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            incident.CreateDateTime = update.StartDateTime;
            incident.Status = "open";
            update.Status = "open";

            db.CreateIncident(incident);
            db.CreateUpdate(update);

            EmailSender.SendIncidentEmail(db, incident);
            EmailSender.SendUpdateEmail(db, update);

            this.Close();
        }

        private void LiveCallDetail_Load(object sender, EventArgs e)
        {
            if (db != null)
            {
                List<string> storeList = db.GetStoreList();
                this.storeList.Items.AddRange(storeList.ToArray());
            }
        }
    }
}
