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
    public partial class frmGoodsReceiveNote : Form
    {
        int fcboDefaultValue = 0;
        public frmGoodsReceiveNote()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGoodsReceiveNote_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtfrmLoad();
        }

        private void AtfrmLoad()
        {
            string ISQL = string.Empty;
            ISQL = " SELECT cgdCode, cgdDesc"
                 + " FROM CatDtl"
                 + " WHERE cgCode = 8"
                 + " ORDER BY cgdDesc";


            clsFillCombo.FillCombo(cboType, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboType.SelectedValue);

            ISQL = " SELECT cgdCode, cgdDesc"
                 + " FROM CatDtl"
                 + " WHERE cgCode = 9"
                 + " ORDER BY cgdDesc";


            clsFillCombo.FillCombo(cboLCNumber, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboLCNumber.SelectedValue);

            ISQL = " SELECT cgdCode, cgdDesc"
                 + " FROM CatDtl"
                 + " WHERE cgCode = 6"
                 + " ORDER BY cgdDesc";


            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            ISQL = " SELECT cgdCode, cgdDesc"
                 + " FROM CatDtl"
                 + " WHERE cgCode = 20"
                 + " ORDER BY cgdDesc";


            clsFillCombo.FillCombo(cboGate, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboGate.SelectedValue);



        }


    }
}
