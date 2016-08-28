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




    }
}

