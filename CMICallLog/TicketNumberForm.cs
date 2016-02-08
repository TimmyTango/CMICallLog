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
    public partial class TicketNumberForm : Form
    {
        private Database db;

        public TicketNumberForm(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void TicketNumberForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = db.GetTicketNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SetTicketNumber(textBox1.Text);
            this.Close();
        }
    }
}
