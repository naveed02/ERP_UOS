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
    public partial class Cheque_Return : Form
    {
        public Cheque_Return()
        {
            InitializeComponent();
        }

        

       private void button3_Click(object sender, EventArgs e)
        {
            Unposted_Vouchers_Help frm = new Unposted_Vouchers_Help();

            frm.ShowDialog();
        }

       private void Cheque_Return_Load(object sender, EventArgs e)
       {
           this.MaximizeBox = false;
       }
    }
}
