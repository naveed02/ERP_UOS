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
    public partial class frmCatDtl : Form
    {
        int fcboDefaultValue = 0;
        public frmCatDtl()
        {
            InitializeComponent();
        }

        private void frmCatagory_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;
            lSQL = "Select cgCode, cgDesc "
                 + "from Category"
                 + " ORDER BY cgDesc";

            clsFillCombo.FillCombo(cboCat, clsGVar.ConString1, "Category" + "," + "cgCode" + "," + "False", lSQL, true);
            fcboDefaultValue = Convert.ToInt16(cboCat.SelectedValue);
        }
    }
}
