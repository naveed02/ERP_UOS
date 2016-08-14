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
    public partial class Cheque_Receipt_Voucher : Form
    {
        public Cheque_Receipt_Voucher()
        {
            InitializeComponent();
        }

        private void Cheque_Receipt_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Cheque_Receipt_Vouchers frm = new Cheque_Receipt_Vouchers();
            frm.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
