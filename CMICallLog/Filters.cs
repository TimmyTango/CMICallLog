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
    public partial class Filters : Form
    {
        public FilterState State;

        public Filters(FilterState state)
        {
            InitializeComponent();
            State = state;
            showAdtFiltersBox.Checked = state.ShowAdditionalFilters;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            State.ShowAdditionalFilters = showAdtFiltersBox.Checked;
            this.Close();
        }
    }

    public class FilterState
    {
        public FilterState()
        {
            ShowAdditionalFilters = true;
        }

        public bool ShowAdditionalFilters
        {
            get;
            set;
        }
    }
}
