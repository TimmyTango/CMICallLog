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
    public partial class UpdateDetailsControl : UserControl
    {
        public Database db;

        public UpdateDetailsControl()
        {
            InitializeComponent();

            type.Items.AddRange(Constants.UpdateType);
            status.Items.AddRange(Constants.Status);
        }

        public void SetControlData(Update update)
        {
            /*
                private int updateNumber;
                private Incident incident;
                private DateTime startDateTime;
                private DateTime endDateTime;
                private string updateBy;
                private string type;
                private string status;
                private string description;
            */
            updateNumber.DataBindings.Add("Text", update, "UpdateNumber");
            incidentNumber.DataBindings.Add("Text", update.Incident, "IncidentNumber");
            startDateTime.DataBindings.Add("Value", update, "StartDateTime");
            endDateTime.DataBindings.Add("Value", update, "EndDateTime");
            updateBy.DataBindings.Add("Text", update, "UpdateBy");
            type.DataBindings.Add("Text", update, "Type");
            status.DataBindings.Add("Text", update, "Status");
            description.DataBindings.Add("Text", update, "Description");
        }
    }
}
