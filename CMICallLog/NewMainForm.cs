using ClosedXML.Excel;
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
    public partial class NewMainForm : Form
    {
        Database db;
        FilterState state;

        public NewMainForm()
        {
            InitializeComponent();
            db = new Database();
            state = new FilterState();
        }

        private DataGridView GetActiveGrid()
        {
            if (mainTabControl.SelectedTab == openIncidentsTab)
            {
                return openIncidentsGrid;
            }
            else if (mainTabControl.SelectedTab == closedIncidentsTab)
            {
                return closedIncidentsGrid;
            }
            return null;
        }
        
        private void PopulateStoreListBox()
        {
            storeListBox.Items.Add("All Stores");
            storeListBox.SelectedIndex = 0;
            List<string> storeList = db.GetStoreList();
            storeListBox.Items.AddRange(storeList.ToArray());
        }

        private void LoadIncidents(string store = null)
        {
            DataGridView active = GetActiveGrid();
            int saveRow = 0;
            int selectedRow = 0;

            if (active != null)
            {
                if (active.Rows.Count > 0)
                {
                    saveRow = active.FirstDisplayedCell.RowIndex;
                    selectedRow = active.CurrentCell.RowIndex;
                }
            }
            
            if(active == openIncidentsGrid)
            {
                PopulateGridView(db.GetOpenIncidents(state, store), active);
            }
            else if(active == closedIncidentsGrid)
            {
                PopulateGridView(db.GetClosedIncidents(state, store), active);
            }

            if (saveRow < active.Rows.Count
                && selectedRow < active.Rows.Count)
            {
                active.FirstDisplayedScrollingRowIndex = saveRow;
                active.CurrentCell = active[0, selectedRow];
            }  
        }

        private void PopulateGridView(DataSet ds, DataGridView activeGrid)
        {

            /*
            CREATE TABLE "incidents" (
	            `incidentNumber`	INTEGER NOT NULL,
	            `storeNumber`	INTEGER NOT NULL,
	            `contactName`	TEXT,
	            `createDateTime`	TEXT NOT NULL,
	            `contactType`	TEXT,
	            `problemType`	TEXT,
	            `status`	TEXT,
	            `priority`	TEXT DEFAULT 'Normal',
	            `posManual`	INTEGER DEFAULT 0,
	            `problem`	TEXT,
	            PRIMARY KEY(incidentNumber)
            )
            */
            DataTable table = ds.Tables["incidents"];

            table.Columns["incidentNumber"].ColumnName = "Incident";
            table.Columns["storeNumber"].ColumnName = "Store";
            table.Columns.Remove("contactName");
            table.Columns["createDateTime"].ColumnName = "Date/Time";
            table.Columns.Remove("contactType");
            table.Columns.Remove("problemType");
            table.Columns["status"].ColumnName = "Status";
            //table.Columns.Remove("priority");
            table.Columns.Remove("posManual");

            table.Columns["problem"].ColumnName = "Problem";

            activeGrid.DataSource = table;
            foreach (DataGridViewColumn col in activeGrid.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (col.Name == "priority")
                {
                    col.Visible = false;
                }
            }
            activeGrid.Columns["problem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach(DataGridViewRow row in activeGrid.Rows)
            {
                switch(row.Cells["priority"].Value.ToString().ToLower())
                {
                    case "low":
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    case "high":
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case "priority":
                        row.DefaultCellStyle.BackColor = Color.Red;
                        break;
                }

                switch(row.Cells["status"].Value.ToString().ToLower())
                {
                    case "level 3":
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        break;
                    case "level 4":
                        row.DefaultCellStyle.BackColor = Color.Purple;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        break;
                }

                Incident inc = new Incident();
                inc.IncidentNumber = int.Parse(row.Cells["Incident"].Value.ToString());
                string upd = db.GetLatestUpdateForIncident(inc);
                if (upd != "")
                    row.Cells["problem"].Value = upd;
            }
            //Dictionary<string, string> desc = db.GetLatestUpdatesForOpenIncidents();

        }

        private void ReloadIncidents()
        {
            string store = storeListBox.SelectedItem.ToString();
            if (store == "All Stores")
            {
                LoadIncidents();
            }
            else
            {
                LoadIncidents(store);
            }
        }

        private void CreateIncident()
        {
            string store = storeListBox.SelectedItem.ToString();
            if (store == "All Stores")
            {
                store = storeListBox.Items[1].ToString();
            }
            CreateIncidentForm form = new CreateIncidentForm(db, store);
            DialogResult res = form.ShowDialog();

            if(res == DialogResult.OK)
            {

            }

            ReloadIncidents();
        }

        private void EditIncident(DataGridView grid)
        {
            string incidentNumber = grid.SelectedRows[0].Cells[0].Value.ToString();
            IncidentDetail form = new IncidentDetail(db, incidentNumber);
            form.ShowDialog();
            ReloadIncidents();
        }

        private void DeleteIncident()
        {
            string incidentNumber = openIncidentsGrid.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete incident " + incidentNumber +
                "?\nThis cannot be undone!", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                db.DeleteIncident(incidentNumber);
            ReloadIncidents();
        }

        /* EVENTS */

        private void NewMainForm_Load(object sender, EventArgs e)
        {
            PopulateStoreListBox();
        }

        private void storeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadIncidents();
        }

        private void openIncidentsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    openIncidentsGrid.Rows[rowSelected].Selected = true;
                }
            }
        }

        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            ReloadIncidents();
        }

        private void openIncidentsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditIncident(openIncidentsGrid);
        }

        private void createIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateIncident();
        }

        private void editSelectedIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == openIncidentsTab)
            {
                EditIncident(openIncidentsGrid);
            }
            else if (mainTabControl.SelectedTab == closedIncidentsTab)
            {
                EditIncident(closedIncidentsGrid);
            }
        }

        private void deleteSelectedIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteIncident();
        }

        private void closedIncidentsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditIncident(closedIncidentsGrid);
        }

        private void closedIncidentsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    closedIncidentsGrid.Rows[rowSelected].Selected = true;
                }
            }
        }

        private void tsQuickBtn_Click(object sender, EventArgs e)
        {
            string store = storeListBox.SelectedItem.ToString();
            if (store == "All Stores")
            {
                store = storeListBox.Items[1].ToString();
            }

            LiveCallDetail form = new LiveCallDetail(db, store);
            form.ShowDialog();
            ReloadIncidents();
        }

        private void completeIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == openIncidentsTab)
            {
                string incidentNumber = openIncidentsGrid.SelectedRows[0].Cells[0].Value.ToString();

                Incident inc = db.GetIncidentDetails(incidentNumber);
                Update update = new Update(inc);
                update.Status = "closed";
                update.Type = "Work Ticket";

                CreateUpdateForm form = new CreateUpdateForm(db, update);
                form.ShowDialog();
                ReloadIncidents();
            }
        }

        private void setDBLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseDbLocation form = new ChooseDbLocation();
            form.ShowDialog();
            ReloadIncidents();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView activeGrid = GetActiveGrid();

            string ticketNum = activeGrid.SelectedRows[0].Cells["Incident"].Value.ToString();
            Incident inc = db.GetIncidentDetails(ticketNum);
            List<Update> updates = db.GetUpdatesForIncident(inc);

            Program.CopyToClipboard(inc, updates);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = exportDialog.ShowDialog();            
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            XLWorkbook wb = new XLWorkbook();
            DataGridView gridView = GetActiveGrid();
            var ws = wb.Worksheets.Add((DataTable)gridView.DataSource);

            // Colorize the worksheet
            foreach(var row in ws.Rows())
            {
                string priority = row.Cell("E").Value.ToString();
                string status = row.Cell("D").Value.ToString();
                XLColor color = XLColor.White;
                XLColor text = XLColor.Black;

                switch(priority)
                {
                    case "Low":
                        color = XLColor.BabyBlue;
                        break;
                    case "High":
                        color = XLColor.Orange;
                        break;
                    case "Priority":
                        color = XLColor.Red;
                        break;
                }

                switch(status)
                {
                    case "Level 3":
                        color = XLColor.Green;
                        text = XLColor.White;
                        break;
                    case "Level 4":
                        color = XLColor.Purple;
                        text = XLColor.White;
                        break;
                }

                row.Style.Fill.BackgroundColor = color;
                row.Style.Font.FontColor = text;
            }

            // Remove the priority column
            ws.Column("E").Delete();

            wb.SaveAs(exportDialog.FileName);
        }

        private void emailTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailSettings form = new EmailSettings(db);
            form.ShowDialog();
        }

        private void storeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStoreManagers form = new SetStoreManagers(db);
            form.ShowDialog();
        }

        private void tsFiltersBtn_Click(object sender, EventArgs e)
        {
            Filters form = new Filters(state);
            form.ShowDialog();
            ReloadIncidents();
        }
    }
}
