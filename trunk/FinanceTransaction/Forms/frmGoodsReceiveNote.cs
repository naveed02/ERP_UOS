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
    public partial class frmGoodsReceiveNote : Form
    {
        public frmGoodsReceiveNote()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGoodsReceiveNote_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
