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
    public partial class frmGoodsReceiveNoteReturn : Form
    {
        public frmGoodsReceiveNoteReturn()
        {
            InitializeComponent();
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGoodsReceiveNotReturn_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;
          
        }
    }
}
