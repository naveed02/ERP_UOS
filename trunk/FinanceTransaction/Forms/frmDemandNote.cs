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
    public partial class frmDemandNote : Form
    {
        int fcboDefaultValue = 0;
        
        public frmDemandNote()
        {
            InitializeComponent();
        }



        private void frmDemandNote_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;
            AtfrmLoad();
        }


        private void AtfrmLoad()
        {
            string ISQL = string.Empty;
            ISQL = " SELECT cgdCode, cgdDesc"
                 + " FROM CatDtl"
                 + " WHERE cgCode = 2"
                 + " ORDER BY cgdDesc";


            clsFillCombo.FillCombo(cboGodownForBal, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboGodownForBal.SelectedValue);


            ISQL = " SELECT cgdCode, cgdDesc"
                 + " FROM CatDtl"
                 + " WHERE cgCode = 6"
                 + " ORDER BY cgdDesc";


            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            ISQL = " SELECT employeeid, first_name + last_name"
                 + " FROM PR_Employee"
                 + " ORDER BY employeeid";

            clsFillCombo.FillCombo(cboEmpCode, clsGVar.ConString1, "employeeid" + "," + "first_name + last_name" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboEmpCode.SelectedValue);

            ISQL = " SELECT departmentid, department_name"
                 + " from PR_Department"
                 + " order by departmentid";

            clsFillCombo.FillCombo(cboDepartment, clsGVar.ConString1, "departmentid" + "," + "department_name" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboDepartment.SelectedValue);



        }



       



        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

//select DNId,  Date, ItemGroupId, DepartmentId,EmployeeId, Note from DN
       

            frmLookUp sForm = new frmLookUp(
                    " DNId",
                    " Date, ItemGroupId, DepartmentId, EmployeeId, Note",
                    " DN",
                    this.Text.ToString(),
                    1,
                    "DN #, DN Date, Item Group, Department, Employee Name, Note",
                    "15,15,15,15,15,15",
                    " T, T, T, T,T,T",
                    true,
                    "",
                    "",
                    "TextBox"
                    );
            txtDemandNoteNumber.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();
            if (txtDemandNoteNumber.Text != null)
            {
                if (txtDemandNoteNumber.Text != null)
                {
                    if (txtDemandNoteNumber.Text.ToString() == "" || txtDemandNoteNumber.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtDemandNoteNumber.Text.ToString().Trim().Length > 0)
                    {
                        //PopulateRecords();
                        //SumVoc();
                    }
                }
            }
        }

            private void PassDataVocID(object sender)
       {
           txtDemandNoteNumber.Text = ((TextBox)sender).Text;

       }

            

            private void btnF1Help_Click(object sender, EventArgs e)
            {
                LookUp_Voc();
            }

            private void txtDemandNoteNumber_DoubleClick(object sender, EventArgs e)
            {
                LookUp_Voc();
            }

            private void txtDemandNoteNumber_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.F1)
                {
                    LookUp_Voc();
                }
            }

          

    }
}

