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
    public partial class frmAccount_Description : Form
    {
        public frmAccount_Description()
        {
            InitializeComponent();
        }

        private void frmAccount_Description_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnbutton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
