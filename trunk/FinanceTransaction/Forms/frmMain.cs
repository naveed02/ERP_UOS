using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_Resource_Planning
{
    public partial class frmEnterpriseResourcePlanning : Form
    {
        public frmEnterpriseResourcePlanning()
        {
            InitializeComponent();
        }

        private void demandNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemandNote frm = new frmDemandNote();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmEnterpriseResourcePlanning_Load(object sender, EventArgs e)
        {

        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder frm = new frmPurchaseOrder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gateInwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGateInward frm = new frmGateInward();
            frm.MdiParent = this;
            frm.Show();
        }

        private void goodsRecieveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodsReceiveNote frm = new frmGoodsReceiveNote();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gateOutwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGateOutward frm = new frmGateOutward();
            frm.MdiParent = this;
            frm.Show();
        }

        private void leToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLedgerStatement frm = new frmLedgerStatement();
            frm.MdiParent = this;
            frm.Show();
        }

        private void finishItemRecieveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinishItemReceive frm = new frmFinishItemReceive();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemsOpeningBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemsOpeningBalance frm = new frmItemsOpeningBalance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void receiveablesPayablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceiveablesPayables frm = new frmReceiveablesPayables();
            frm.MdiParent = this;
            frm.Show();
        }

        private void groupWiseAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroupWiseAccounts frm = new frmGroupWiseAccounts();
            frm.MdiParent = this;
            frm.Show();
        }

        private void periodWithAccountsMallKhataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodWiseAccounts frm = new frmPeriodWiseAccounts();
            frm.MdiParent = this;
            frm.Show();
        }

        private void customerWiseAgingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerWiseAgingDueReceiveables frm = new frmCustomerWiseAgingDueReceiveables();
            frm.MdiParent = this;
            frm.Show();
        }

        private void goodsRecieveNotReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodsReceiveNotReturn frm = new frmGoodsReceiveNotReturn();
            frm.MdiParent = this;
            frm.Show();
        }

       

      

       
       
    }
}
