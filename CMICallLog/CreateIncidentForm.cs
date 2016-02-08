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
    public partial class CreateIncidentForm : Form
    {
        Database db;
        Incident incident;

        public CreateIncidentForm(Database db, string selectedStore)
        {
            InitializeComponent();
            this.db = db;
            incident = new Incident();
            incident.StoreNumber = int.Parse(selectedStore);
            incidentDetailControl1.db = db;
            incidentDetailControl1.SetControlData(incident);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            db.CreateIncident(incident);

            SendCreatedEmail();

            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            db.CreateIncident(incident);

            SendCreatedEmail();

            Incident cloned = new Incident();
            cloned.StoreNumber = incident.StoreNumber;
            cloned.CreateDateTime = incident.CreateDateTime;
            cloned.ContactName = incident.ContactName;
            cloned.ContactType = incident.ContactType;
            cloned.Status = incident.Status;
            incident = cloned;

            incidentDetailControl1.SetControlData(incident);
        }

        private void SendCreatedEmail()
        {
            EmailSender.SendIncidentEmail(db, incident);
        }
    }
}
