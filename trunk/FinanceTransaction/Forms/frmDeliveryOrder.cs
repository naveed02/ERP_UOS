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
    public partial class frmDeliveryOrder : Form
    {
        public frmDeliveryOrder()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDeliveryOrder_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
