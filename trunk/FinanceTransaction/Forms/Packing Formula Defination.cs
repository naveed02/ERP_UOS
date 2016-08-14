using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP_UOS
{
    public partial class frmPacking : Form
    {
        public frmPacking()
        {
            InitializeComponent();
        }

        private void frmPacking_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
        }
    }
}
