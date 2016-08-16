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
    public partial class frmGroupWiseAccounts : Form
    {
        public frmGroupWiseAccounts()
        {
            InitializeComponent();
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGroupWiseAccounts_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
