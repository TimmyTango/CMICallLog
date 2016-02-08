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
    public partial class IncidentDetail : Form
    {
        Database db;
        Incident incident;
        List<Update> updates;
        string incidentNumber;

        public IncidentDetail(Database db, string incidentNumber)
        {
            InitializeComponent();
            details.db = db;
            this.db = db;
            this.incidentNumber = incidentNumber;
            LoadIncident();
            LoadUpdates();
        }

        public void LoadIncident()
        {
            incident = db.GetIncidentDetails(incidentNumber);
            details.SetControlData(incident);
        }

        public void LoadUpdates()
        {
            updatesList.Nodes.Clear();
            updates = db.GetUpdatesForIncident(incident);
            foreach(Update update in updates)
            {
                string text = "Update [" + update.UpdateNumber + "] " +
                    "Created By [" + update.UpdateBy + "] " +
                    "Status [" + update.Status + "] " +
                    "Type [" + update.Type + "]";
                TreeNode startDT = new TreeNode("Start Date/Time [" + update.StartDateTime.ToString(Database.dateFormat) + "]");
                TreeNode endDT = new TreeNode("End Date/Time [" + update.EndDateTime.ToString(Database.dateFormat) + "]");
                TreeNode description = new TreeNode("Description: " + update.Description);
                TreeNode[] nodes = { startDT, endDT, description };
                TreeNode main = new TreeNode(text, nodes);
                updatesList.Nodes.Add(main);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(incident.Problem);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            db.UpdateIncident(incident);
            this.Close();
        }

        private void updDeleteBtn_Click(object sender, EventArgs e)
        {
            Update upd;

            if (updatesList.SelectedNode == null)
                return;
            else if (updatesList.SelectedNode.Parent == null)
                upd = updates[updatesList.SelectedNode.Index];
            else
                upd = updates[updatesList.SelectedNode.Parent.Index];

            DialogResult result = MessageBox.Show("Are you sure you want to delete update " + 
                upd.UpdateNumber.ToString() + "?\nThis cannot be undone!", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                db.DeleteUpdate(upd.UpdateNumber.ToString());
            LoadUpdates();
            LoadIncident();
        }

        private void updCreateBtn_Click(object sender, EventArgs e)
        {
            CreateUpdateForm form = new CreateUpdateForm(db, new Update(incident));
            form.ShowDialog();
            LoadUpdates();
            LoadIncident();
        }

        private void updEditBtn_Click(object sender, EventArgs e)
        {
            Update upd;

            if (updatesList.SelectedNode == null)
                return;
            else if (updatesList.SelectedNode.Parent == null)
                upd = updates[updatesList.SelectedNode.Index];
            else
                upd = updates[updatesList.SelectedNode.Parent.Index];

            CreateUpdateForm form = new CreateUpdateForm(db, upd);
            form.ShowDialog();
            LoadUpdates();
            LoadIncident();
        }

        private void updatesList_ControlAdded(object sender, ControlEventArgs e)
        {
            //MessageBox.Show("Test");
        }
    }
}
