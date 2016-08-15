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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        private void frmItem_Load(object sender, EventArgs e)
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
                 + " ORDER BY cgdDesc ";

            clsFillCombo.FillCombo(cboGroup, clsGVar.ConString1, "CatDtl", lSQL, false);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
