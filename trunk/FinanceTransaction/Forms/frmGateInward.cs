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
    public partial class frmGateInward : Form
    {
        public frmGateInward()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGateInward_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void txtGateInwardNo_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void LookUp_Voc()
        {
            // 1- KeyField
            // 2- Field List
            // 3- Table Name
            // 4- Form Title
            // 5- Default Find Field (Int) 0,1,2,3 etc Default = 1 = title field
            // 6- Grid Title List
            // 7- Grid Title Width
            // 8- Grid Title format T = Text, N = Numeric etc
            // 9- Bool One Table = True, More Then One = False
            // 10 Join String Otherwise Empty String.
            // 11 Optional Where
            // 11 Return Control Type TextBox or MaskedTextBox Default mtextBox
            //

//            SELECT m.GateInwordId, m.[Date], m.Note, c.cgdDesc
//FROM GateInword m
//Inner JOIN CatDtl c ON m.ItemGroupID = c.cgdCode AND c.cgCode = 6
       

            frmLookUp sForm = new frmLookUp(
                    "m.GateInwordId",
                    "m.[Date], m.Note, c.cgdDesc",
                    " GateInword m Inner JOIN CatDtl c ON m.ItemGroupID = c.cgdCode AND c.cgCode = 6 ",
                    this.Text.ToString(),
                    1,
                    "Voc #, Date, Note, Item Name",
                    "6,8,10,12",
                    " T, T, T, T",
                    true,
                    "",
                    "",
                    "TextBox"
                    );
            txtGateInwardNo.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();
            if (txtGateInwardNo.Text != null)
            {
                if (txtGateInwardNo.Text != null)
                {
                    if (txtGateInwardNo.Text.ToString() == "" || txtGateInwardNo.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtGateInwardNo.Text.ToString().Trim().Length > 0)
                    {
                        //PopulateRecords();
                        //SumVoc();
                    }
                }
            }
        }

        private void PassDataVocID(object sender)
        {
            txtGateInwardNo.Text = ((TextBox)sender).Text;
        }

        private void txtGateInwardNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_Voc();
            }
        }

        //Populate Recordset 
        //private void PopulateRecords()
        //{
        //    DataSet ds = new DataSet();
        //    DataRow dRow;
        //    string tSQL = string.Empty;

        //    // Fields 0,1,2,3 are Begin  

        //    tSQL = "select t.doc_id, t.doc_strid, t.doc_date, t.doc_remarks, t.doc_amt, "
        //         + " t.GLID, ga.ac_strid, ga.ac_title, t.[Desc], u.UserName AS created_by, t.created_date, "
        //         + " u2.UserName AS modified_by, t.modified_date "
        //         + " from gl_Tran t "
        //         + " LEFT OUTER JOIN gl_ac ga ON t.GLID=ga.ac_id "
        //         + " LEFT OUTER JOIN Users u ON t.created_by = u.UserID "
        //         + " LEFT OUTER JOIN Users u2 ON t.modified_by = u2.UserID ";
        //    tSQL += " where  t.doc_vt_id=" + fDocTypeID.ToString() + " and t.doc_fiscal_id=1 and t.doc_status=1";
        //    tSQL += " and t.doc_id=" + lblDocID.Text.ToString() + ";";

        //    tSQL += " select 1 as Status, d.Serial_No, d.Serial_Order, ";
        //    tSQL += " d.AC_ID, a.ac_strid, a.ac_title, d.NARRATION, d.DEBIT, d.CREDIT, d.ChqNo, t.Doc_Remarks";
        //    tSQL += " from gl_Tran t Left Outer join gl_trandtl d on t.doc_vt_id=d.doc_vt_id";
        //    tSQL += " and t.doc_fiscal_id=d.doc_fiscal_id ";
        //    tSQL += " and t.Doc_ID=d.Doc_ID";
        //    tSQL += " inner join gl_ac a on a.ac_id=d.AC_ID";
        //    tSQL += " where  t.doc_vt_id=" + fDocTypeID.ToString() + " and t.doc_fiscal_id=1 and t.doc_status=1";
        //    tSQL += " and t.doc_id=" + lblDocID.Text.ToString();
        //    tSQL += " and d.Debit>0";
        //    tSQL += " order by d.SERIAL_No";

        //    //tSQL = "Select top 1 ac_title, ac_id, ac_strid from gl_ac Where ";
        //    //tSQL = tSQL + " ac_strid = '" + msk_AccountID.Text + "';";
        //    try
        //    {
        //        ds = clsDbManager.GetData_Set(tSQL, "gl_tran");
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            //fAlreadyExists = true;
        //            dRow = ds.Tables[0].Rows[0];
        //            // Starting title as 0
        //            txtManualDoc.Text = (ds.Tables[0].Rows[0]["doc_strid"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["doc_strid"].ToString());
        //            msk_VocDate.Text = (ds.Tables[0].Rows[0]["doc_date"] == DBNull.Value ? DateTime.Now.ToString("T") : ds.Tables[0].Rows[0]["doc_date"].ToString());
        //            txtRemarks.Text = (ds.Tables[0].Rows[0]["doc_remarks"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["doc_remarks"].ToString());
        //            msk_VocMasterGLID.Text = (ds.Tables[0].Rows[0]["Ac_StrID"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["Ac_StrID"].ToString());
        //            lblVocCodeName.Text = (ds.Tables[0].Rows[0]["Ac_Title"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["Ac_Title"].ToString());
        //            lblVocCodeName.Tag = (ds.Tables[0].Rows[0]["GLID"] == DBNull.Value ? "0" : ds.Tables[0].Rows[0]["GLID"].ToString());
        //            txtDesc.Text = (ds.Tables[0].Rows[0]["Desc"] == DBNull.Value ? "0" : ds.Tables[0].Rows[0]["Desc"].ToString());
        //            lblCreatedBy.Text = (ds.Tables[0].Rows[0]["created_by"] == DBNull.Value ? "0" : ds.Tables[0].Rows[0]["created_by"].ToString());
        //            lblCreatedOn.Text = (ds.Tables[0].Rows[0]["created_date"] == DBNull.Value ? "0" : ds.Tables[0].Rows[0]["created_date"].ToString());
        //            lblModifiedBy.Text = (ds.Tables[0].Rows[0]["modified_by"] == DBNull.Value ? "0" : ds.Tables[0].Rows[0]["modified_by"].ToString());
        //            lblModifiedOn.Text = (ds.Tables[0].Rows[0]["modified_date"] == DBNull.Value ? "0" : ds.Tables[0].Rows[0]["modified_date"].ToString());
        //            fEditMod = true;


        //            if (ds.Tables[0].Rows.Count > 0)
        //            {
        //                ds.Clear();
        //            }
        //        }
        //    }

        //    catch
        //    {
        //        MessageBox.Show("Unable to Get Account Code...", this.Text.ToString());
        //    }
        //}
    }
}
