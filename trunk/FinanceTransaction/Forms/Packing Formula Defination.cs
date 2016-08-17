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
    public partial class frmPacking : Form
    {
        int fcboDefaultValue = 0;
        public frmPacking()
        {
            InitializeComponent();
        }

        private void frmPacking_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
           AtFormLoad();
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;

            lSQL = "SELECT cgdCode, cgdDesc "
                 + " FROM CatDtl "
                 + " WHERE cgCode = 5 "
                 + " ORDER BY cgdDesc";

            clsFillCombo.FillCombo(cboSize, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL, true);
            fcboDefaultValue = Convert.ToInt16(cboSize.SelectedValue);

            lSQL = "select cgdCode, cgdDesc "
                + " from CatDtl "
                + " where cgCode = 3 "
                + " ORDER BY cgdDesc ";

            clsFillCombo.FillCombo(cboColor, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL, true);
            fcboDefaultValue = Convert.ToInt16(cboColor.SelectedValue);
        
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
        }
    }
}
