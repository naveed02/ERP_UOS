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
    public partial class frmCash : Form
    {
        public frmCash()
        {
            InitializeComponent();
        }

        private void frmCash_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
