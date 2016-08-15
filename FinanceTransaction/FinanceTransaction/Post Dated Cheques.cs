using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceTransaction
{
    public partial class Post_Dated_Cheques : Form
    {
        public Post_Dated_Cheques()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Due_Cheques frm = new Due_Cheques();
            frm.ShowDialog();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            Daily_Cheques frm = new Daily_Cheques();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Daily_Chq frm = new Daily_Chq();
            frm.ShowDialog();
        }
        private void Post_Dated_Cheques_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

    }
}
