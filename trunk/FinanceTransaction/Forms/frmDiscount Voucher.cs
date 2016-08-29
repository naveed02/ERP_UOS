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
    public partial class frmDiscountVoucher : Form
    {
        public frmDiscountVoucher()
        {
            InitializeComponent();
        }

        private void Discount_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           frmAccountSelection frm = new frmAccountSelection();

            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       }
  }

