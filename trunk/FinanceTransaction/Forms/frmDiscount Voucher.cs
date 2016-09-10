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
    public partial class frmDiscountVoucher : Form
    {
        public frmDiscountVoucher()
        {
            InitializeComponent();
        }

        private void Discount_Voucher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           frmAccountSelection frm = new frmAccountSelection();

            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LookUp_GL()
        {
            // select ac_id, ac_title
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
        private void PassDataVocID_GL(object sender)
        {
            mskCustomer.Text = ((TextBox)sender).Text;
        }

        private void mskCustomer_DoubleClick(object sender, EventArgs e)
        {
            LookUp_GL();
        }

       }
  }

