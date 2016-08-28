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
    public partial class frmInvoiceEntry : Form
    {
        int fcboDefaultValue = 0;
        public frmInvoiceEntry()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoiceEntry_Load(object sender, EventArgs e)
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
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            ISQL = " select cgdCode,CgdDesc"
                    + " from CatDtl"
                    + " where cgCode=15"
                    + " order by cgdDesc";

            clsFillCombo.FillCombo(cboMainGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", ISQL, true);
            fcboDefaultValue = Convert.ToInt16(cboMainGroup.SelectedValue);

            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
