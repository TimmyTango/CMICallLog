using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMICallLog
{
    public partial class IncidentDetailControl : UserControl
    {
        public Database db;

        public IncidentDetailControl()
        {
            InitializeComponent();

            contactTypeBox.Items.AddRange(Constants.ContactType);
            statusBox.Items.AddRange(Constants.Status);
            problemTypeBox.Items.AddRange(Constants.ProblemType);
            priorityBox.Items.AddRange(Constants.Priority);
        }

        public void SetControlData(Incident incident)
        {
            /*
                public int incidentNumber;
                public int storeNumber;
                public string contactName;
                public DateTime createDateTime;
                public string contactType;
                public string problemType;
                public string status;
                public string priority;
                public bool posManual;
                public string problem;
            */
            incidentBox.DataBindings.Clear();
            storeNumberBox.DataBindings.Clear();
            contactNameBox.DataBindings.Clear();
            createDateTime.DataBindings.Clear();
            contactTypeBox.DataBindings.Clear();
            problemTypeBox.DataBindings.Clear();
            statusBox.DataBindings.Clear();
            priorityBox.DataBindings.Clear();
            manualCheckbox.DataBindings.Clear();
            problemBox.DataBindings.Clear();

            incidentBox.DataBindings.Add("Text", incident, "IncidentNumber");            
            storeNumberBox.DataBindings.Add("Text", incident, "StoreNumber");
            contactNameBox.DataBindings.Add("Text", incident, "ContactName");
            createDateTime.DataBindings.Add("Value", incident, "CreateDateTime");
            contactTypeBox.DataBindings.Add("Text", incident, "ContactType");
            problemTypeBox.DataBindings.Add("Text", incident, "ProblemType");
            statusBox.DataBindings.Add("Text", incident, "Status");
            priorityBox.DataBindings.Add("Text", incident, "Priority");
            manualCheckbox.DataBindings.Add("Checked", incident, "PosManual");
            problemBox.DataBindings.Add("Text", incident, "Problem");
        }

        private void IncidentDetailControl_Load(object sender, EventArgs e)
        {

            if (db != null)
            {
                List<string> storeList = db.GetStoreList();
                storeNumberBox.Items.AddRange(storeList.ToArray());
            }

        }
    }
}
