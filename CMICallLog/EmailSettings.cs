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
    public partial class EmailSettings : Form
    {
        Database db;

        public EmailSettings(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("emailHost", hostTextBox.Text);
            settings.Add("emailFrom", fromEmailTextBox.Text);
            settings.Add("emailUser", usernameTextBox.Text);
            settings.Add("emailPassword", passwordTextBox.Text);

            string emailTo = "";
            if (l54Box.Checked)
                emailTo += "list54@cmi9800.com,";
            if (storeBox.Checked)
                emailTo += "[STORE],";
            if (superBox.Checked)
                emailTo += "[SUPER],";
            if (opsBox.Checked)
                emailTo += "[OPSMGR],";
            settings.Add("emailTo", emailTo);

            db.UpdateEmailSettings(settings);
            this.Close();
        }

        private void EmailSettings_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> settings = db.GetEmailSettings();
            if(settings != null)
            {
                if (settings.ContainsKey("emailHost"))
                    hostTextBox.Text = settings["emailHost"];
                if (settings.ContainsKey("emailFrom"))
                    fromEmailTextBox.Text = settings["emailFrom"];
                if (settings.ContainsKey("emailUser"))
                    usernameTextBox.Text = settings["emailUser"];
                if (settings.ContainsKey("emailPassword"))
                    passwordTextBox.Text = settings["emailPassword"];
                if(settings.ContainsKey("emailTo"))
                {
                    string[] tos = settings["emailTo"].Split(',');
                    foreach(string to in tos)
                    {
                        switch(to)
                        {
                            case "list54@cmi9800.com":
                                l54Box.Checked = true;
                                break;
                            case "[STORE]":
                                storeBox.Checked = true;
                                break;
                            case "[SUPER]":
                                superBox.Checked = true;
                                break;
                            case "[OPSMGR]":
                                opsBox.Checked = true;
                                break;
                        }
                    }
                }
            }
        }
    }
}
