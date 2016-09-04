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
    public partial class frmFinishItemReceive : Form
    {
        int fcboDefaultValue = 0;
        public frmFinishItemReceive()
        {
            InitializeComponent();
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinishItemReceive_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtfrmLoad();
        }

        private void AtfrmLoad()
        {
            string ISQL = string.Empty;

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


            ISQL = " select distinct 1, RIGHT(ItemCode,1)"
                 +  " from Item";

            clsFillCombo.FillCombo(cboCategory, clsGVar.ConString1, "employeeid" + "," + "first_name + last_name" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboCategory.SelectedValue);



        }


    }
}
