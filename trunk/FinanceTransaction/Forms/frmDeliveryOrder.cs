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
    public partial class frmDeliveryOrder : Form
    {
        int fcboDefaultValue = 0;
        public frmDeliveryOrder()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDeliveryOrder_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }
        private void AtFormLoad()
        {
            string ISQL = string.Empty;

            ISQL = "SELECT cgdCode, cgdDesc "
                 + " FROM CatDtl "
                 + " WHERE cgCode = 6 "
                 + " ORDER BY cgdDesc";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            ISQL = " select cgdCode,CgdDesc"
                + " from CatDtl"
                + " where cgCode=15"
                + " order by cgdDesc";

            clsFillCombo.FillCombo(cboMainGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboMainGroup.SelectedValue);

            ISQL = " select cgdCode,CgdDesc"
                  + " from CatDtl"
                  + " where cgCode=14"
                  + " order by cgdDesc";

            clsFillCombo.FillCombo(cboAdda, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboAdda.SelectedValue);

        }
    }
}
