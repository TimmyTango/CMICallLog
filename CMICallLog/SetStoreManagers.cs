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
    public partial class SetStoreManagers : Form
    {
        Database db;

        public SetStoreManagers(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void SetStoreManagers_Load(object sender, EventArgs e)
        {
            string[] ops = db.GetOpsManagers();
            opsBox.Items.AddRange(ops);
        }

        private void supersBox_SelectedValueChanged(object sender, EventArgs e)
        {
            supersBox.Items.Clear();
            string[] supers = db.GetSupersForOps(opsBox.SelectedItem.ToString());
            supersBox.Items.AddRange(supers);
        }

        private void storesBox_SelectedValueChanged(object sender, EventArgs e)
        {
            storesBox.Items.Clear();
            string[] stores = db.GetStoresForSuper(supersBox.SelectedItem.ToString());
            storesBox.Items.AddRange(stores);
        }
    }
}
