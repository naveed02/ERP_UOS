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
    public partial class frmSaleOrderEntryQuotation : Form
    {
        int fcboDefaultValue = 0;

        public frmSaleOrderEntryQuotation()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSaleOrderEntryQuotation_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtfrmLoad();
        }


        private void AtfrmLoad()
        {
         string ISQL = String.Empty;
                ISQL = " select cgdCode,CgdDesc"
                     + " from CatDtl"
                     + " where cgCode=6"
                     + " order by cgdDesc";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue= Convert.ToInt16(cboItemGroup.SelectedValue);

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

            clsFillCombo.FillCombo(cboTransport, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboTransport.SelectedValue);
        }
    }

}
