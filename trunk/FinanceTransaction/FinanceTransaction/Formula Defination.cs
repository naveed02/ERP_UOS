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
    public partial class frmFormula : Form
    {
        public frmFormula()
        {
            InitializeComponent();
        }

        private void frmFormula_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
        }

      
       

    }
}
