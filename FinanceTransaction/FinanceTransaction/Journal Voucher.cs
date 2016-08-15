using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceTransaction
{
    public partial class Journal_Voucher : Form
    {
        public Journal_Voucher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Voucher_Help vh = new Voucher_Help();
            vh.Show();
        }

        private void Journal_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
