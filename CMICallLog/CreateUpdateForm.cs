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
    public partial class CreateUpdateForm : Form
    {
        Database db;
        Update update;

        public CreateUpdateForm(Database db, Update update)
        {
            InitializeComponent();
            this.db = db;
            this.update = update;
            details.db = db;
            details.SetControlData(update);

            if (update.UpdateNumber != 0)
                confirmBtn.Text = "Update";
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(confirmBtn.Text == "Create")
            {
                db.CreateUpdate(update);
                update.Incident.Status = update.Status;
                db.UpdateIncident(update.Incident);
            }
            else
            {
                db.UpdateUpdate(update);
            }

            SendUpdateEmail();
            this.Close();
        }

        private void SendUpdateEmail()
        {
            EmailSender.SendUpdateEmail(db, update);
        }
    }
}
