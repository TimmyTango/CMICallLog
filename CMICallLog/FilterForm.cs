using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMICallLog
{
    public partial class FilterForm : Form
    {
        public string filter;

        public FilterForm(string currentFilter)
        {
            InitializeComponent();
            if (currentFilter.Length > 0)
            {
                int i1 = currentFilter.IndexOf('\'');
                int i2 = currentFilter.LastIndexOf('\'');
                filter = currentFilter.Substring(i1 + 1, i2 - i1 - 1);
            }
            else
                filter = "";
            storeNumberBox.Text = filter;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string newFilter = storeNumberBox.Text;
            if (newFilter.Length > 0)
                filter = String.Format("storeNumber='{0}'", newFilter);
            else
                filter = "";

            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            storeNumberBox.Text = "";
        }
    }
}
