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
    public partial class frmDemandNote : Form
    {
        public frmDemandNote()
        {
            InitializeComponent();
        }

        

        private void frmDemandNote_Load(object sender, EventArgs e)
        {
            
            this.MaximizeBox = false;
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNoteBottom_Click(object sender, EventArgs e)
        {

        }

        
    }
}
