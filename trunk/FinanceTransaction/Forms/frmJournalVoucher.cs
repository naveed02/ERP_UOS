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
    public partial class frmJournalVoucher : Form
    {
        public frmJournalVoucher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVoucherHelp vh = new FrmVoucherHelp();
            vh.Show();
        }

        private void Journal_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
