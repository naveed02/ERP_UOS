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
    public partial class frmBank_Payment_Voucher : Form
    {
        public frmBank_Payment_Voucher()
        {
            InitializeComponent();
        }

        private void Bank_Payment_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Unposted_Vouchers_Help frm = new Unposted_Vouchers_Help();

            frm.ShowDialog();
        }
    }
}
