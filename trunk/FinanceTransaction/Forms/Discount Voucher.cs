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
    public partial class Discount_Voucher : Form
    {
        public Discount_Voucher()
        {
            InitializeComponent();
        }

        private void Discount_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Account_Selection frm = new Account_Selection();

            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       }
  }

