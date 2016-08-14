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
    public partial class frmCheque_to_Cheque : Form
    {
        public frmCheque_to_Cheque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unposted_Vouchers_Help frm = new Unposted_Vouchers_Help();
            frm.ShowDialog();
        }

        private void Cheque_to_Cheque_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

        }

       

       
        

     
    }
}
