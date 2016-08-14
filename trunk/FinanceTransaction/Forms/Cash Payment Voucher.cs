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
    public partial class Cash_Payment_Voucher : Form
    {
        public Cash_Payment_Voucher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Voucher_Help vh = new Voucher_Help();
            vh.Show();
        }

        private void Cash_Payment_Voucher_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Voucher_Help frm = new Voucher_Help();
            frm.ShowDialog();
        }
    }
}
