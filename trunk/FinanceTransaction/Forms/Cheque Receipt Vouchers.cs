﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP_UOS
{
    public partial class Cheque_Receipt_Vouchers : Form
    {
        public Cheque_Receipt_Vouchers()
        {
            InitializeComponent();
        }

        private void Cheque_Receipt_Vouchers_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
