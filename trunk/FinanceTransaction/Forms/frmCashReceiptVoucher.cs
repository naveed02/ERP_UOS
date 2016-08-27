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
    public partial class Cash_Receipt_Voucher : Form
    {
        public Cash_Receipt_Voucher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmVoucherHelp vh =new FrmVoucherHelp();
            //vh.ShowDialog();

            LookUp_Voc();
        }


        private void Cash_Receipt_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LookUp_Voc()
        {
//            select doc_id, doc_strid, Convert(VARCHAR(10), doc_date, 103) AS doc_date, doc_amt
//from gl_tran
//where doc_vt_id = 269

            frmLookUp sForm = new frmLookUp(
            "doc_id",
            "doc_strid, Convert(VARCHAR(10), doc_date, 103), doc_amt",
            "gl_tran",
            
            this.Text.ToString(),
            1,
            "ID,Voc #, Date, Amount",
            "10,10,10,10",
            "T,T,T,T",
            true,
            "",
            "",
            "TextBox"
            );
            //
            sForm.lupassControl = new frmLookUp.LUPassControl(PassData);
            sForm.ShowDialog();
        }

        private void PassData(object sender)
        {
            txtVocNo.Text = ((TextBox)sender).Text;
        }

        private void txtVocNo_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void txtVocNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_Voc();
            }
        }

       
    }
}
