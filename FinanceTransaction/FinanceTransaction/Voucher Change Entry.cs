using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceTransaction
{
    public partial class Voucher_Change_Entry : Form
    {
        public Voucher_Change_Entry()
        {
            InitializeComponent();
        }

       
        private void Voucher_Change_Entry_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Posted_Invoice_Help frm = new Posted_Invoice_Help();
            frm.ShowDialog();

        }


      

       

     
    }
}
