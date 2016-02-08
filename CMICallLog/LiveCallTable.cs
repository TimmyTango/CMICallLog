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
    public partial class LiveCallTable : Form
    {
        Database db;

        public LiveCallTable(Database db)
        {
            InitializeComponent();

            this.db = db;
        }

        private void LiveCallTable_Load(object sender, EventArgs e)
        {
            RefreshDataset();
        }

        private void RefreshDataset()
        {
            DataSet ds = db.GetLiveProblems();
            DataTable table = ds.Tables["live_problems"];
            table.Columns[0].ColumnName = "ID";
            table.Columns[1].ColumnName = "Store";
            table.Columns[2].ColumnName = "Caller";
            table.Columns[3].ColumnName = "Contact";
            table.Columns[4].ColumnName = "Start";
            table.Columns[5].ColumnName = "End";
            table.Columns[6].ColumnName = "Type";
            table.Columns[7].ColumnName = "Problem";
            table.Columns[8].ColumnName = "Resolution";
            table.Columns[9].ColumnName = "Priority";
            table.Columns[10].ColumnName = "Manual";

            liveProblemsGridView.DataSource = ds.Tables["live_problems"];
            foreach (DataGridViewColumn col in liveProblemsGridView.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiveCallDetail form = new LiveCallDetail(db);
            DialogResult res = form.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                RefreshDataset();
            }
        }

        private void liveProblemsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editSelectedToolStripMenuItem_Click(sender, e);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDataset();
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newEntryToolStripMenuItem_Click(sender, e);
        }

        private void editSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string rowId = liveProblemsGridView.SelectedRows[0].Cells["id"].Value.ToString();
            //LiveCallDetail form = new LiveCallDetail(db, Int32.Parse(rowId));
            //DialogResult res = form.ShowDialog();
            //if (res != DialogResult.Cancel)
            //{
            //    RefreshDataset();
            //}
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rowId = liveProblemsGridView.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult res = MessageBox.Show("Are you sure you want to delete this entry?", "Warning", MessageBoxButtons.YesNo);            
            if (res == DialogResult.Yes)
            {
                //delete record
                db.DeleteLiveProblem(Int32.Parse(rowId));
                RefreshDataset();
            }
        }

        private void liveProblemsGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    liveProblemsGridView.Rows[rowSelected].Selected = true;
                }
            }
        }
    }
}
