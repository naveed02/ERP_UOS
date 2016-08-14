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
    public partial class frmFinishItemReceive : Form
    {
        public frmFinishItemReceive()
        {
            InitializeComponent();
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinishItemReceive_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
