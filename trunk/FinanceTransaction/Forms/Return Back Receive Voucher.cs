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
    public partial class Return_Back_Receive_Voucher : Form
    {
        public Return_Back_Receive_Voucher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unposted_Vouchers_Help frm = new Unposted_Vouchers_Help();
            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
