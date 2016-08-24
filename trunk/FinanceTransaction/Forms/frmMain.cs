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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cash_Receipt_Voucher frm = new Cash_Receipt_Voucher();
           frm.MdiParent = this;
           frm.Show();
        }

        private void cashPaymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Cash_Payment_Voucher frm = new Cash_Payment_Voucher();
           frm.MdiParent = this;
            frm.Show();

        }

        private void journalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journal_Voucher frm = new Journal_Voucher();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bankReceiptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankReceiptVoucher frm = new frmBankReceiptVoucher();
            frm.MdiParent = this;
            frm.Show();

        }
        private void bnakPaymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBank_Payment_Voucher frm = new frmBank_Payment_Voucher();
            frm.MdiParent = this;
            frm.Show();
        }
        private void discountVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Discount_Voucher frm = new Discount_Voucher();
            frm.MdiParent = this;
            frm.Show();
                 
        }
        private void checkReceiveVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cheque_Receipt_Voucher frm = new Cheque_Receipt_Voucher();
            frm.MdiParent = this;
            frm.Show();

        }
        private void checkPaymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cheque_Payment_Voucher frm = new Cheque_Payment_Voucher();
            frm.MdiParent = this;
            frm.Show();
        }

        private void returnBackReceiveVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Back_Receive_Voucher frm = new Return_Back_Receive_Voucher();
            frm.MdiParent = this;
            frm.Show();
        }
        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cheque_Return frm = new Cheque_Return();
            frm.MdiParent = this;
            frm.Show();

        }
        private void salaryMakingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Making frm = new Salary_Making();
            frm.MdiParent = this;
            frm.Show();
        }
        private void chequeToChequeCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheque_to_Cheque frm = new frmCheque_to_Cheque();
            frm.MdiParent = this;
            frm.Show();
        }
        private void postDatedChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Post_Dated_Cheques frm = new Post_Dated_Cheques();
            frm.MdiParent = this;
            frm.Show();

        }
        private void journalVoucherChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voucher_Change_Entry frm = new Voucher_Change_Entry();
            frm.MdiParent = this;
            frm.Show();

        }
        private void salaryPostingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Posting frm = new Salary_Posting();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salaryStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Report frm = new Salary_Report();
            frm.MdiParent = this;
            frm.Show();
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void payRolMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fiananceTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountDiscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount_Description frm = new frmAccount_Description();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoryDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatDtl frm = new frmCatDtl();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formullaDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormula frm = new frmFormula();
            frm.MdiParent = this;
            frm.Show();
        }

        private void packFormulaDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacking frm = new frmPacking();
            frm.MdiParent = this;
            frm.Show();
        }

        private void groupSizeColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroup frm = new frmGroup();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cashStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCash frm = new frmCash();
            frm.MdiParent = this;
            frm.Show();

        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReturn frm = new frmSalesReturn();
             frm.MdiParent = this;
            frm.Show();

        }

      

        private void ledgerStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLedgerStatement frm = new frmLedgerStatement();
            frm.MdiParent = this;
            frm.Show();
        }

        private void demandNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemandNote frm = new frmDemandNote();
            frm.MdiParent = this;
            frm.Show();
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

        private void goodsReceiveNoteToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void goodsRecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodsReceiveNote frm = new frmGoodsReceiveNote();
            frm.MdiParent = this;
            frm.Show();
        }

        private void receiveablePayablesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void periodWiseAccountsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void saleOrderEntryQuotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleOrderEntryQuotation frm = new frmSaleOrderEntryQuotation();
            frm.MdiParent = this;
            frm.Show();

        }

        private void saleOrderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleOrderEntry frm = new frmSaleOrderEntry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void deliveryOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void invoiceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoiceEntry frm = new frmInvoiceEntry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void finishItemReceiveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void goodsReceiveNoteReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodsReceiveNoteReturn frm = new frmGoodsReceiveNoteReturn();
            frm.MdiParent = this;
            frm.Show();
        }

      
        
       
       

       

      
        

       

        

     

       
        

      

      
    }
}
