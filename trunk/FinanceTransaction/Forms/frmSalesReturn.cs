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
    public partial class frmSalesReturn : Form
    {
        public frmSalesReturn()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
