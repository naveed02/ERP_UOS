using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_Resource_Planning
{
    public partial class frmLedgerStatement : Form
    {
        public frmLedgerStatement()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       // private void btnEscExit_Click(object sender, EventArgs e)
       // {
           // MessageBox.Show("jsdbj");
       // }

        private void frmLedgerStatement_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

        }

        private void btnEscExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
