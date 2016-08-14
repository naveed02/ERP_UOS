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
    public partial class frmReceiveablesPayables : Form
    {
        public frmReceiveablesPayables()
        {
            InitializeComponent();
        }

        private void frmReceiveablesPayables_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
