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
    public partial class frmSaleOrderEntryQuotation : Form
    {
        public frmSaleOrderEntryQuotation()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSaleOrderEntryQuotation_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
