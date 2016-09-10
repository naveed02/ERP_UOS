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
    public partial class frmChequePaymentVoucher : Form
    {
        public frmChequePaymentVoucher()
        {
            InitializeComponent();
        }

        private void Cheque_Payment_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             //    Cheque_Payment_Vouchers frm = new Cheque_Payment_Vouchers();
            //    frm.ShowDialog();
            LookUp_Voc();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LookUp_Voc()
        {
            //select m.doc_id,Convert(VARCHAR(10), doc_date, 103) AS doc_date,m.doc_amt,a.CustCode,a.CustName
            //from gl_tran m
            //left outer join GL_CustDesc a ON
            //m.GLID = a.OrgID

            frmLookUp sForm = new frmLookUp(
            " m.doc_id",
            " m.doc_date, m.doc_amt,a.CustCode,a.CustName",
            " gl_tran m left outer join GL_CustDesc a ON m.GLID = a.OrgID",
             this.Text.ToString(),
             1,
            "Voc #, Date, Amount,Cust Code,Cust Name",
            "10,10,10,10,10",
            "T,T,T,T,T",
            true,
            "",
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
            //select CustCode,CustName 
            //from GL_CustDesc

            frmLookUp sForm = new frmLookUp(
            " CustCode",
            " CustName",
            " GL_CustDesc",
             this.Text.ToString(),
             1,
            "Cust Code,Cust Name",
            "10,10",
            "T,T",
            true,
            "",
            "",
            "TextBox"
            );

            mskCustomer.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID_GL);
            sForm.ShowDialog();
            if (mskCustomer.Text != null)
            {
                if (mskCustomer.Text != null)
                {
                    if (mskCustomer.Text.ToString() == "" || mskCustomer.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (mskCustomer.Text.ToString().Trim().Length > 0)
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
            mskCustomer.Text = ((TextBox)sender).Text;
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

        private void mskCustomer_DoubleClick(object sender, EventArgs e)
        {
            LookUp_GL();
        }
       

      

        

       
      
      
    }
}
