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
    public partial class Cash_Receipt_Voucher : Form
    {
        public Cash_Receipt_Voucher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Voucher_Help vh =new Voucher_Help();
            vh.ShowDialog();
        }


        private void Cash_Receipt_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

      

       

       

      

      
       
       
     

     
    }
}
