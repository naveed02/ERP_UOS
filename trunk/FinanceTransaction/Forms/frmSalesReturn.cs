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
    public partial class frmSalesReturn : Form
    {
        int fcboDefaultValue = 0;

        public frmSalesReturn()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;

            lSQL = "SELECT cgdCode, cgdDesc "
                 + " FROM CatDtl "
                 + " WHERE cgCode = 6 "
                 + " ORDER BY cgdDesc";

            clsFillCombo.FillCombo(cboGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL, true);
            fcboDefaultValue = Convert.ToInt16(cboGroup.SelectedValue);
        }
    }
}
