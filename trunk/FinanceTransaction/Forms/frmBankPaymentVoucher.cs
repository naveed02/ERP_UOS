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
    public partial class frmBankPaymentVoucher : Form
    {
        public frmBankPaymentVoucher()
        {
            InitializeComponent();
        }
        private void frmBankPaymentVoucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LookUp_Voc()
        {
            //select m.doc_id, m.doc_strid,  a.created_date ,m.doc_amt,a.ac_strid,a.ac_title
              //from gl_tran m
           //left outer join gl_ac a ON
        //m.GLID = a.ac_id
         //where doc_vt_id = 270

            frmLookUp sForm = new frmLookUp(
            " m.doc_id",
            " m.doc_date, m.doc_amt,a.ac_strid,a.ac_title",
            " gl_tran m left outer join gl_ac a ON m.GLID = a.ac_id",
             this.Text.ToString(),
             1,
            "Voc #, Date, Amount,Bank Code,Bank Name",
            "10,10,10,10,10",
            "T,T,T,T,T",
            true,
            " m.doc_vt_id = " + clsGVar.BPV.ToString(),
            "",
            "TextBox"

            );



            txtVocNo.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();
            if (txtVocNo.Text != null)
            {
                if (txtVocNo.Text != null)
                {
                    if (txtVocNo.Text.ToString() == "" || txtVocNo.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtVocNo.Text.ToString().Trim().Length > 0)
                    {
                        //PopulateRecords();
                        //SumVoc();
                    }
                }
            }
        }
        
        private void LookUp_GL()
        {
//            select ac_id, ac_title
//from gl_ac

            frmLookUp sForm = new frmLookUp(
            " ac_strid",
            " ac_title",
            " gl_ac",
             this.Text.ToString(),
             1,
            "Bank Code,Bank Name",
            "10,10",
            "T,T",
            true,
            "",
            "",
            "TextBox"
            );

            mskBank.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID_GL);
            sForm.ShowDialog();
            if (mskBank.Text != null)
            {
                if (mskBank.Text != null)
                {
                    if (mskBank.Text.ToString() == "" || mskBank.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (mskBank.Text.ToString().Trim().Length > 0)
                    {
                        //PopulateRecords();
                        //SumVoc();
                    }
                }
            }
        }

        private void PassDataVocID(object sender)
        {
            txtVocNo.Text = ((TextBox)sender).Text;
        }

        private void PassDataVocID_GL(object sender)
        {
            mskBank.Text = ((TextBox)sender).Text;
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

        private void mskBank_DoubleClick(object sender, EventArgs e)
        {
            LookUp_GL();
        }
    }
}
