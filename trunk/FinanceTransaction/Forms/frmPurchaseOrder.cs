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
    }
}
