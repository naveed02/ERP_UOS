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
    public partial class frmChequeToCheque : Form
    {
        public frmChequeToCheque()
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

        private void btn8_Click(object sender, EventArgs e)
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
