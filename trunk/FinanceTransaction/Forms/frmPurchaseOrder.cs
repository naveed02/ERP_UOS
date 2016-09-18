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
    public partial class frmPurchaseOrder : Form
    {
        int fcboDefaultValue = 0;
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void AtFormLoad()
        {
            string ISQL = string.Empty;

            ISQL = " SELECT cgdCode, cgdDesc"
                 + " FROM CatDtl"
                 + " WHERE cgCode = 6"
                 + " ORDER BY cgdDesc";


            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            ISQL = " SELECT employeeid, first_name + ' ' + last_name"
                 + " FROM PR_Employee"
                 + " ORDER BY employeeid";

            clsFillCombo.FillCombo(cboEmpCode, clsGVar.ConString1, "employeeid" + "," + "first_name + last_name" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboEmpCode.SelectedValue);

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optOfficePoint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LookUp_Voc()
        {
            // 1- KeyField
            // 2- Field List
            // 3- Table Name
            // 4- Form Title
            // 5- Default Find Field (Int) 0,1,2,3 etc Default = 1 = title field
            // 6- Grid Title List
            // 7- Grid Title Width
            // 8- Grid Title format T = Text, N = Numeric etc
            // 9- Bool One Table = True, More Then One = False
            // 10 Join String Otherwise Empty String.
            // 11 Optional Where
            // 11 Return Control Type TextBox or MaskedTextBox Default mtextBox
            //

            //select POId, Date, DNId, DNDate,EmployeeId, Note from PO


            frmLookUp sForm = new frmLookUp(
                    " POId",
                    " Date, DNId, DNDate, EmployeeId, Note",
                    "PO",
                    this.Text.ToString(),
                    1,
                    "PO #, PO Date, Demand Note #, DN Date, Employee Name, Note",
                    "15,15,15,15,15,15",
                    " T, T, T, T,T,T",
                    true,
                    "",
                    "",
                    "TextBox"
                    );
            txtPurchaseOrderNumber.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();
            if (txtPurchaseOrderNumber.Text != null)
            {
                if (txtPurchaseOrderNumber.Text != null)
                {
                    if (txtPurchaseOrderNumber.Text.ToString() == "" || txtPurchaseOrderNumber.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtPurchaseOrderNumber.Text.ToString().Trim().Length > 0)
                    {
                        //PopulateRecords();
                        //SumVoc();
                    }
                }
            }
        }

        private void PassDataVocID(object sender)
        {
            txtPurchaseOrderNumber.Text = ((TextBox)sender).Text;

        }

        private void btnF1Help1_Click(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void txtPurchaseOrderNumber_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void txtPurchaseOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_Voc();
            }
        }



       
        



    }
}

