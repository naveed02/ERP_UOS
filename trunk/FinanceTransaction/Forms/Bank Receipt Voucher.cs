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
    public partial class frmBank_Receipt_Voucher : Form
    {
        public frmBank_Receipt_Voucher()
        {
            InitializeComponent();
        }

         private void Bank_Receipt_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

         private void button2_Click(object sender, EventArgs e)
         {
             Unposted_Vouchers_Help frm = new Unposted_Vouchers_Help();

             frm.ShowDialog();
         }

         
         
    }
}
