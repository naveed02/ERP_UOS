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
    public partial class Cash_Payment_Voucher : Form
    {
        public Cash_Payment_Voucher()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //FrmVoucherHelp vh = new FrmVoucherHelp();
        //    //vh.Show();
        //    LookUp_Voc();
        //}

        private void Cash_Payment_Voucher_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            //
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //FrmVoucherHelp frm = new FrmVoucherHelp();
            //frm.ShowDialog();
            LookUp_Voc();

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



            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();
        }
        private void PassDataVocID(object sender)
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

