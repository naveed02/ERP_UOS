namespace ERP_UOS
{
    partial class frmPurchaseOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDemandNote = new System.Windows.Forms.TextBox();
            this.cboEmpCode = new System.Windows.Forms.ComboBox();
            this.txtVendorCode = new System.Windows.Forms.TextBox();
            this.txtPurchaserCode = new System.Windows.Forms.TextBox();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.txtNoteUpper = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDateUpper = new System.Windows.Forms.DateTimePicker();
            this.dtpDateLower = new System.Windows.Forms.DateTimePicker();
            this.optMultiItemGroupSizeColour = new System.Windows.Forms.RadioButton();
            this.optSingleItemGroupSizeColour = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameUpper = new System.Windows.Forms.Label();
            this.lblNameLower = new System.Windows.Forms.Label();
            this.optInProcess = new System.Windows.Forms.RadioButton();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.btnF1Help1 = new System.Windows.Forms.Button();
            this.btnF1Help2 = new System.Windows.Forms.Button();
            this.btnF1Help3 = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnF1Help4 = new System.Windows.Forms.Button();
            this.grdPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.optForPurchasePoint = new System.Windows.Forms.RadioButton();
            this.optOfficePoint = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNoteBottom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSuggestionOfCash = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPurchaseOrderNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Purchase Order #";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Demand Note";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Emp Code";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vendor Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Purchaser Code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Item Group";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Note";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDemandNote
            // 
            this.txtDemandNote.Location = new System.Drawing.Point(151, 35);
            this.txtDemandNote.Name = "txtDemandNote";
            this.txtDemandNote.Size = new System.Drawing.Size(149, 21);
            this.txtDemandNote.TabIndex = 8;
            // 
            // cboEmpCode
            // 
            this.cboEmpCode.FormattingEnabled = true;
            this.cboEmpCode.Location = new System.Drawing.Point(151, 61);
            this.cboEmpCode.Name = "cboEmpCode";
            this.cboEmpCode.Size = new System.Drawing.Size(297, 23);
            this.cboEmpCode.TabIndex = 9;
            // 
            // txtVendorCode
            // 
            this.txtVendorCode.Location = new System.Drawing.Point(151, 89);
            this.txtVendorCode.Name = "txtVendorCode";
            this.txtVendorCode.Size = new System.Drawing.Size(149, 21);
            this.txtVendorCode.TabIndex = 10;
            // 
            // txtPurchaserCode
            // 
            this.txtPurchaserCode.Location = new System.Drawing.Point(151, 116);
            this.txtPurchaserCode.Name = "txtPurchaserCode";
            this.txtPurchaserCode.Size = new System.Drawing.Size(149, 21);
            this.txtPurchaserCode.TabIndex = 11;
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(151, 144);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(297, 23);
            this.cboItemGroup.TabIndex = 12;
            // 
            // txtNoteUpper
            // 
            this.txtNoteUpper.Location = new System.Drawing.Point(151, 174);
            this.txtNoteUpper.Name = "txtNoteUpper";
            this.txtNoteUpper.Size = new System.Drawing.Size(329, 21);
            this.txtNoteUpper.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "Name";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label4_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(306, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtpDateUpper
            // 
            this.dtpDateUpper.Location = new System.Drawing.Point(429, 9);
            this.dtpDateUpper.Name = "dtpDateUpper";
            this.dtpDateUpper.Size = new System.Drawing.Size(108, 21);
            this.dtpDateUpper.TabIndex = 18;
            // 
            // dtpDateLower
            // 
            this.dtpDateLower.Location = new System.Drawing.Point(429, 35);
            this.dtpDateLower.Name = "dtpDateLower";
            this.dtpDateLower.Size = new System.Drawing.Size(108, 21);
            this.dtpDateLower.TabIndex = 19;
            // 
            // optMultiItemGroupSizeColour
            // 
            this.optMultiItemGroupSizeColour.AutoSize = true;
            this.optMultiItemGroupSizeColour.Checked = true;
            this.optMultiItemGroupSizeColour.Location = new System.Drawing.Point(14, 20);
            this.optMultiItemGroupSizeColour.Name = "optMultiItemGroupSizeColour";
            this.optMultiItemGroupSizeColour.Size = new System.Drawing.Size(192, 19);
            this.optMultiItemGroupSizeColour.TabIndex = 24;
            this.optMultiItemGroupSizeColour.TabStop = true;
            this.optMultiItemGroupSizeColour.Text = "Multi Item Group (Size/Colour)";
            this.optMultiItemGroupSizeColour.UseVisualStyleBackColor = true;
            // 
            // optSingleItemGroupSizeColour
            // 
            this.optSingleItemGroupSizeColour.AutoSize = true;
            this.optSingleItemGroupSizeColour.Location = new System.Drawing.Point(14, 45);
            this.optSingleItemGroupSizeColour.Name = "optSingleItemGroupSizeColour";
            this.optSingleItemGroupSizeColour.Size = new System.Drawing.Size(200, 19);
            this.optSingleItemGroupSizeColour.TabIndex = 25;
            this.optSingleItemGroupSizeColour.Text = "Single Item Group (Size/Colour)";
            this.optSingleItemGroupSizeColour.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optSingleItemGroupSizeColour);
            this.groupBox1.Controls.Add(this.optMultiItemGroupSizeColour);
            this.groupBox1.Location = new System.Drawing.Point(671, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 78);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lblNameUpper
            // 
            this.lblNameUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblNameUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameUpper.Location = new System.Drawing.Point(430, 89);
            this.lblNameUpper.Name = "lblNameUpper";
            this.lblNameUpper.Size = new System.Drawing.Size(322, 21);
            this.lblNameUpper.TabIndex = 27;
            this.lblNameUpper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameLower
            // 
            this.lblNameLower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblNameLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameLower.Location = new System.Drawing.Point(429, 116);
            this.lblNameLower.Name = "lblNameLower";
            this.lblNameLower.Size = new System.Drawing.Size(322, 21);
            this.lblNameLower.TabIndex = 28;
            // 
            // optInProcess
            // 
            this.optInProcess.AutoSize = true;
            this.optInProcess.Checked = true;
            this.optInProcess.Location = new System.Drawing.Point(660, 172);
            this.optInProcess.Name = "optInProcess";
            this.optInProcess.Size = new System.Drawing.Size(86, 19);
            this.optInProcess.TabIndex = 30;
            this.optInProcess.TabStop = true;
            this.optInProcess.Text = "In Process";
            this.optInProcess.UseVisualStyleBackColor = true;
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Location = new System.Drawing.Point(752, 172);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(125, 19);
            this.optApprovedVerified.TabIndex = 31;
            this.optApprovedVerified.Text = "Approved/Verified";
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            // 
            // btnF1Help1
            // 
            this.btnF1Help1.Location = new System.Drawing.Point(555, 9);
            this.btnF1Help1.Name = "btnF1Help1";
            this.btnF1Help1.Size = new System.Drawing.Size(75, 21);
            this.btnF1Help1.TabIndex = 32;
            this.btnF1Help1.Text = "F1=Help";
            this.btnF1Help1.UseVisualStyleBackColor = true;
            this.btnF1Help1.Click += new System.EventHandler(this.btnF1Help1_Click);
            // 
            // btnF1Help2
            // 
            this.btnF1Help2.Location = new System.Drawing.Point(555, 35);
            this.btnF1Help2.Name = "btnF1Help2";
            this.btnF1Help2.Size = new System.Drawing.Size(75, 21);
            this.btnF1Help2.TabIndex = 33;
            this.btnF1Help2.Text = "F1=Help";
            this.btnF1Help2.UseVisualStyleBackColor = true;
            // 
            // btnF1Help3
            // 
            this.btnF1Help3.Location = new System.Drawing.Point(555, 61);
            this.btnF1Help3.Name = "btnF1Help3";
            this.btnF1Help3.Size = new System.Drawing.Size(75, 21);
            this.btnF1Help3.TabIndex = 34;
            this.btnF1Help3.Text = "F1=Help";
            this.btnF1Help3.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(462, 61);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 21);
            this.btnAddNew.TabIndex = 35;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnF1Help4
            // 
            this.btnF1Help4.Location = new System.Drawing.Point(660, 144);
            this.btnF1Help4.Name = "btnF1Help4";
            this.btnF1Help4.Size = new System.Drawing.Size(75, 23);
            this.btnF1Help4.TabIndex = 36;
            this.btnF1Help4.Text = "F1=Help";
            this.btnF1Help4.UseVisualStyleBackColor = true;
            // 
            // grdPurchaseOrder
            // 
            this.grdPurchaseOrder.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grdPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.grdPurchaseOrder.Location = new System.Drawing.Point(13, 201);
            this.grdPurchaseOrder.Name = "grdPurchaseOrder";
            this.grdPurchaseOrder.Size = new System.Drawing.Size(903, 222);
            this.grdPurchaseOrder.TabIndex = 37;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.NullValue = false;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "?";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Code";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item Code";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Colour";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "UOM";
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Stock";
            this.Column8.Name = "Column8";
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "DN Qty";
            this.Column9.Name = "Column9";
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "PO Qty";
            this.Column10.Name = "Column10";
            this.Column10.Width = 70;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Remaining Qty";
            this.Column11.Name = "Column11";
            this.Column11.Width = 70;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Last Rate";
            this.Column12.Name = "Column12";
            this.Column12.Width = 70;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Amount";
            this.Column13.Name = "Column13";
            this.Column13.Width = 70;
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(12, 438);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(89, 23);
            this.btnExitSave.TabIndex = 38;
            this.btnExitSave.Text = "E&xit+Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(110, 438);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(87, 23);
            this.btnPrinting.TabIndex = 39;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(809, 477);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(107, 23);
            this.btnEscExit.TabIndex = 40;
            this.btnEscExit.Text = "< Esc = Exit >";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // optForPurchasePoint
            // 
            this.optForPurchasePoint.AutoSize = true;
            this.optForPurchasePoint.Checked = true;
            this.optForPurchasePoint.Location = new System.Drawing.Point(6, 13);
            this.optForPurchasePoint.Name = "optForPurchasePoint";
            this.optForPurchasePoint.Size = new System.Drawing.Size(133, 19);
            this.optForPurchasePoint.TabIndex = 41;
            this.optForPurchasePoint.TabStop = true;
            this.optForPurchasePoint.Text = "For Purchase Point";
            this.optForPurchasePoint.UseVisualStyleBackColor = true;
            // 
            // optOfficePoint
            // 
            this.optOfficePoint.AutoSize = true;
            this.optOfficePoint.Location = new System.Drawing.Point(140, 13);
            this.optOfficePoint.Name = "optOfficePoint";
            this.optOfficePoint.Size = new System.Drawing.Size(91, 19);
            this.optOfficePoint.TabIndex = 42;
            this.optOfficePoint.Text = "Office Point";
            this.optOfficePoint.UseVisualStyleBackColor = true;
            this.optOfficePoint.CheckedChanged += new System.EventHandler(this.optOfficePoint_CheckedChanged);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(13, 477);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 21);
            this.label15.TabIndex = 43;
            this.label15.Text = "Note";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoteBottom
            // 
            this.txtNoteBottom.Location = new System.Drawing.Point(86, 477);
            this.txtNoteBottom.Name = "txtNoteBottom";
            this.txtNoteBottom.Size = new System.Drawing.Size(329, 21);
            this.txtNoteBottom.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(575, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Qty";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQty.Location = new System.Drawing.Point(629, 438);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(114, 21);
            this.lblQty.TabIndex = 46;
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(749, 438);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 21);
            this.label14.TabIndex = 47;
            this.label14.Text = "Value";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue.Location = new System.Drawing.Point(809, 438);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(107, 21);
            this.lblValue.TabIndex = 48;
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(457, 477);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 21);
            this.label16.TabIndex = 49;
            this.label16.Text = "Suggestion Of Cash";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSuggestionOfCash
            // 
            this.txtSuggestionOfCash.Location = new System.Drawing.Point(595, 477);
            this.txtSuggestionOfCash.Name = "txtSuggestionOfCash";
            this.txtSuggestionOfCash.Size = new System.Drawing.Size(206, 21);
            this.txtSuggestionOfCash.TabIndex = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optForPurchasePoint);
            this.groupBox2.Controls.Add(this.optOfficePoint);
            this.groupBox2.Location = new System.Drawing.Point(213, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 42);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // txtPurchaseOrderNumber
            // 
            this.txtPurchaseOrderNumber.Location = new System.Drawing.Point(150, 9);
            this.txtPurchaseOrderNumber.Name = "txtPurchaseOrderNumber";
            this.txtPurchaseOrderNumber.Size = new System.Drawing.Size(150, 21);
            this.txtPurchaseOrderNumber.TabIndex = 53;
            this.txtPurchaseOrderNumber.DoubleClick += new System.EventHandler(this.txtPurchaseOrderNumber_DoubleClick);
            this.txtPurchaseOrderNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseOrderNumber_KeyDown);
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 510);
            this.Controls.Add(this.txtPurchaseOrderNumber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSuggestionOfCash);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNoteBottom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.grdPurchaseOrder);
            this.Controls.Add(this.btnF1Help4);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnF1Help3);
            this.Controls.Add(this.btnF1Help2);
            this.Controls.Add(this.btnF1Help1);
            this.Controls.Add(this.optApprovedVerified);
            this.Controls.Add(this.optInProcess);
            this.Controls.Add(this.lblNameLower);
            this.Controls.Add(this.lblNameUpper);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDateLower);
            this.Controls.Add(this.dtpDateUpper);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNoteUpper);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.txtPurchaserCode);
            this.Controls.Add(this.txtVendorCode);
            this.Controls.Add(this.cboEmpCode);
            this.Controls.Add(this.txtDemandNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDemandNote;
        private System.Windows.Forms.ComboBox cboEmpCode;
        private System.Windows.Forms.TextBox txtVendorCode;
        private System.Windows.Forms.TextBox txtPurchaserCode;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.TextBox txtNoteUpper;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDateUpper;
        private System.Windows.Forms.DateTimePicker dtpDateLower;
        private System.Windows.Forms.RadioButton optMultiItemGroupSizeColour;
        private System.Windows.Forms.RadioButton optSingleItemGroupSizeColour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameUpper;
        private System.Windows.Forms.Label lblNameLower;
        private System.Windows.Forms.RadioButton optInProcess;
        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.Button btnF1Help1;
        private System.Windows.Forms.Button btnF1Help2;
        private System.Windows.Forms.Button btnF1Help3;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnF1Help4;
        private System.Windows.Forms.DataGridView grdPurchaseOrder;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.RadioButton optForPurchasePoint;
        private System.Windows.Forms.RadioButton optOfficePoint;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNoteBottom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSuggestionOfCash;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPurchaseOrderNumber;
    }
}