using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_Resource_Planning
{
    public partial class frmGateInward : Form
    {
        public frmGateInward()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGateInward_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
