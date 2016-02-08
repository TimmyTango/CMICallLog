using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.IO.Compression;
using CMICallLog;

namespace CMICallLog
{
    public partial class MainForm : Form
    {
        Database db;
        string filter = "";

        public MainForm()
        {
            InitializeComponent();            
            db = new Database();
        }

        private void ViewCallLogForm_Load(object sender, EventArgs e)
        {
            this.refreshDataSet();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string rowId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            TicketDetailForm form = new TicketDetailForm(this.db, rowId);
            DialogResult res = form.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                this.refreshDataSet();
            }
        }

        private void refreshDataSet()
        {
            int saveRow = 0;
            if (dataGridView1.Rows.Count > 0)
                saveRow = dataGridView1.FirstDisplayedCell.RowIndex;

            DataSet ds;
            if (showCompleteTickets.Checked)
                ds = db.GetCompletedTickets(filter);
            else
                ds = db.GetOpenTickets(filter);
            dataGridView1.DataSource = ds.Tables["tickets"];
            //ds.Tables[0].DefaultView.
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["priority"].Value.ToString() == "Low")
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else if (row.Cells["priority"].Value.ToString() == "High")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
            //if (dataGridView1.Columns.Count > 10)
            //{
            //    for (int i = 10; i < dataGridView1.Columns.Count; i++)
            //    {
            //        dataGridView1.Columns[i].Visible = false;
            //    }
            //}

            if (saveRow != 0 && saveRow < dataGridView1.Rows.Count)
                dataGridView1.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketDetailForm form = new TicketDetailForm(this.db);
            DialogResult res = form.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                this.refreshDataSet();
            }
        }

        private void setTicketNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketNumberForm f = new TicketNumberForm(this.db);
            f.ShowDialog();
        }

        private void editSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rowId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            TicketDetailForm form = new TicketDetailForm(this.db,rowId);
            DialogResult res = form.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                this.refreshDataSet();
            }
        }

        private void completeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rowId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            CompleteTicketForm form = new CompleteTicketForm(this.db,rowId);
            DialogResult res = form.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                this.refreshDataSet();
            }
        }

        private void comleteTicketsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.refreshDataSet();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dataGridView1.Rows[rowSelected].Selected = true;
                }
            }
        }

        class CustomComparer : System.Collections.IComparer
        {
            private static int sortMod = 1;

            public CustomComparer(SortOrder sortOrder)
            {
                if (sortOrder == SortOrder.Descending)
                    sortMod = -1;
            }

            public int Compare(object x, object y)
            {
                DataGridViewRow row1 = (DataGridViewRow)x;
                DataGridViewRow row2 = (DataGridViewRow)y;

                string c1 = row1.Cells[6].Value.ToString();
                string c2 = row2.Cells[6].Value.ToString();

                if (c1.Length < c2.Length)
                    return -1 * sortMod;
                else if (c1.Length > c2.Length)
                    return 1 * sortMod;
                else
                {
                    return c1.CompareTo(c2) * sortMod;
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string rowId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            TicketDetailForm form = new TicketDetailForm(this.db, rowId);
            DialogResult res = form.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                this.refreshDataSet();
            }
        }

        private void exportPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            int cols;
            //open file 
            System.IO.StreamWriter wr = new System.IO.StreamWriter(saveFileDialog1.FileName);

            //determine the number of columns and write columns to file 
            cols = dataGridView1.Columns.Count;
            for (int i = 1; i < cols; i++)
            {
                wr.Write(dataGridView1.Columns[i].Name.ToString().ToUpper() + ",");
            }
            wr.WriteLine();

            //write rows to excel file
            for (int i = 0; i < (dataGridView1.Rows.Count - 1); i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        wr.Write("\"" + dataGridView1.Rows[i].Cells[j].Value + "\",");
                    }
                    else
                    {
                        wr.Write(",");
                    }
                }

                wr.WriteLine();
            }

            //close file
            wr.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ticketNum = dataGridView1.SelectedRows[0].Cells["ticketNumber"].Value.ToString();
            string ticketDesc = dataGridView1.SelectedRows[0].Cells["description"].Value.ToString();
            Program.CopyTicketToClipboard(ticketNum, ticketDesc);
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ticketNum = dataGridView1.SelectedRows[0].Cells["ticketNumber"].Value.ToString();
            string ticketDesc = dataGridView1.SelectedRows[0].Cells["description"].Value.ToString();
            Program.CopyTicketToClipboard(ticketNum, ticketDesc);
        }

        private void setFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterForm frm = new FilterForm(filter);
            DialogResult res = frm.ShowDialog();
            
            if (res != DialogResult.Cancel)
            {
                filter = frm.filter;
                this.refreshDataSet();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.refreshDataSet();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.Close();
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");

            using (FileStream fs = new FileStream(@"DB_Backup" + timestamp + ".zip", FileMode.Create))
            using (ZipArchive arch = new ZipArchive(fs, ZipArchiveMode.Create))
            {
                arch.CreateEntryFromFile(Program.DbLocation, "CmiCallLogDB.sqlite");
            }
        }

        private void openAppFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.Diagnostics.Process.Start("explorer.exe", dir);
        }

        private void setDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseDbLocation frm = new ChooseDbLocation();
            frm.ShowDialog();
            this.refreshDataSet();
        }

        private void exportPageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void databaseVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Version: " + Program.version + "\nDatabase Version: " + Database.dbVersion);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Update();
            //System.Diagnostics.Process.Start(@".\updater.exe");
        }

        private void liveProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiveCallTable form = new LiveCallTable(db);
            form.Show();
        }
    }
}
