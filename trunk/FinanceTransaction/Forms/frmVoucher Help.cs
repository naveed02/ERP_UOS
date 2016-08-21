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
    public partial class FrmVoucherHelp : Form
    {
        public FrmVoucherHelp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Voucher_Help_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
