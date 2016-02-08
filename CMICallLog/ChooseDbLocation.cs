using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CMICallLog
{
    public partial class ChooseDbLocation : Form
    {
        public ChooseDbLocation()
        {
            InitializeComponent();
            locationTextBox.Text = Program.DbLocation;
            openDialog.Filter = "SQLite Database (*.sqlite)|*.sqlite|All Files (*.*)|*.*";
            openDialog.FileName = "";
            saveDialog.Filter = "SQLite Database (*.sqlite)|*.sqlite|All Files (*.*)|*.*";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            locationTextBox.Text = openDialog.FileName;
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            if (locationTextBox.Text != "")
                openDialog.InitialDirectory = Path.GetDirectoryName(locationTextBox.Text);
            else
                openDialog.InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            openDialog.ShowDialog(this);
            locationTextBox.Text = openDialog.FileName;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (Program.DbLocation == locationTextBox.Text)
            {
                this.Close();
            }
            else
            {
                Program.WriteSetting("dbLocation", locationTextBox.Text);
                //MessageBox.Show("Program will restart and show new database");
                Application.Restart();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            saveDialog.InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            saveDialog.ShowDialog(this);
        }

        private void saveDialog_FileOk(object sender, CancelEventArgs e)
        {
            Database.SetupNewDatabase(saveDialog.FileName);
            locationTextBox.Text = saveDialog.FileName;
        }
    }
}
