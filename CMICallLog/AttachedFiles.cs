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
    public partial class AttachedFiles : Form
    {
        Database db;

        public AttachedFiles(Database db, string ticketNumber)
        {
            InitializeComponent();
            this.db = db;
            ticketLbl.Text = ticketNumber;
            openDlg.InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            List<string> files = this.db.GetAttachedFiles(ticketNumber);
            foreach(string file in files)
            {
                fileList.Items.Add(file);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            openDlg.ShowDialog(this);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int id = fileList.SelectedIndex;
            if (id != -1)
            {
                string path = fileList.Items[id].ToString();
                db.DetachFile(ticketLbl.Text, path);
                fileList.Items.RemoveAt(id);
            }
        }

        private void openDlg_FileOk(object sender, CancelEventArgs e)
        {
            fileList.Items.Add(openDlg.FileName);
            db.AttachFile(ticketLbl.Text, openDlg.FileName);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileList_DoubleClick(object sender, EventArgs e)
        {
            int id = fileList.SelectedIndex;
            if (id != -1)
            {
                string path = fileList.Items[id].ToString();
                System.Diagnostics.Process.Start(@path);
            }
        }
    }
}
