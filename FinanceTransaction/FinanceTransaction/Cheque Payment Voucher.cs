﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceTransaction
{
    public partial class Cheque_Payment_Voucher : Form
    {
        public Cheque_Payment_Voucher()
        {
            InitializeComponent();
        }

        private void Cheque_Payment_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cheque_Payment_Vouchers frm = new Cheque_Payment_Vouchers();
            frm.ShowDialog();
        }

       
      
      
    }
}
