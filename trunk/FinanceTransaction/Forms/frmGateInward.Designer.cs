namespace Enterprise_Resource_Planning
{
    partial class frmGateInward
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGateInwardNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnF1Help = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grdGateInward = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRecievingPersonName = new System.Windows.Forms.TextBox();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.optInProcess = new System.Windows.Forms.RadioButton();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdGateInward)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gate Inward #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Item Group";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGateInwardNumber
            // 
            this.lblGateInwardNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGateInwardNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateInwardNumber.Location = new System.Drawing.Point(138, 7);
            this.lblGateInwardNumber.Name = "lblGateInwardNumber";
            this.lblGateInwardNumber.Size = new System.Drawing.Size(117, 27);
            this.lblGateInwardNumber.TabIndex = 3;
            this.lblGateInwardNumber.Text = "01-16-1-1";
            this.lblGateInwardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(138, 40);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(369, 21);
            this.txtNote.TabIndex = 5;
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(138, 72);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(315, 23);
            this.cboItemGroup.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(397, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(110, 21);
            this.dtpDate.TabIndex = 7;
            // 
            // btnF1Help
            // 
            this.btnF1Help.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1Help.Location = new System.Drawing.Point(513, 7);
            this.btnF1Help.Name = "btnF1Help";
            this.btnF1Help.Size = new System.Drawing.Size(99, 27);
            this.btnF1Help.TabIndex = 8;
            this.btnF1Help.Text = "F1=Help";
            this.btnF1Help.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(513, 39);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(99, 27);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "&Gate";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboGate
            // 
            this.cboGate.FormattingEnabled = true;
            this.cboGate.Location = new System.Drawing.Point(570, 72);
            this.cboGate.Name = "cboGate";
            this.cboGate.Size = new System.Drawing.Size(305, 23);
            this.cboGate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(729, 39);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(146, 27);
            this.lblTime.TabIndex = 13;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdGateInward
            // 
            this.grdGateInward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGateInward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grdGateInward.Location = new System.Drawing.Point(12, 103);
            this.grdGateInward.Name = "grdGateInward";
            this.grdGateInward.Size = new System.Drawing.Size(863, 294);
            this.grdGateInward.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Code";
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Colour";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "UOM";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Godown";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Qty";
            this.Column9.Name = "Column9";
            this.Column9.Width = 80;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Recieving Person Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecievingPersonName
            // 
            this.txtRecievingPersonName.Location = new System.Drawing.Point(224, 406);
            this.txtRecievingPersonName.Name = "txtRecievingPersonName";
            this.txtRecievingPersonName.Size = new System.Drawing.Size(651, 21);
            this.txtRecievingPersonName.TabIndex = 16;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(101, 436);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(81, 23);
            this.btnPrinting.TabIndex = 23;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(188, 436);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(97, 23);
            this.btnEscExit.TabIndex = 25;
            this.btnEscExit.Text = "< Esc = Exit >";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(12, 436);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(84, 23);
            this.btnExitSave.TabIndex = 24;
            this.btnExitSave.Text = "E&xit+Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // chkPrinter
            // 
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrinter.Location = new System.Drawing.Point(297, 439);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.Size = new System.Drawing.Size(62, 19);
            this.chkPrinter.TabIndex = 26;
            this.chkPrinter.Text = "Printer";
            this.chkPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinter.UseVisualStyleBackColor = true;
            // 
            // optInProcess
            // 
            this.optInProcess.AutoSize = true;
            this.optInProcess.Checked = true;
            this.optInProcess.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInProcess.Location = new System.Drawing.Point(368, 439);
            this.optInProcess.Name = "optInProcess";
            this.optInProcess.Size = new System.Drawing.Size(84, 19);
            this.optInProcess.TabIndex = 27;
            this.optInProcess.TabStop = true;
            this.optInProcess.Text = "In Process";
            this.optInProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optInProcess.UseVisualStyleBackColor = true;
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Location = new System.Drawing.Point(466, 439);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(119, 19);
            this.optApprovedVerified.TabIndex = 28;
            this.optApprovedVerified.Text = "Approved/Verified";
            this.optApprovedVerified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(606, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Total Qty";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalQty.Location = new System.Drawing.Point(689, 436);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(186, 23);
            this.lblTotalQty.TabIndex = 30;
            this.lblTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGateInward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 470);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.optApprovedVerified);
            this.Controls.Add(this.optInProcess);
            this.Controls.Add(this.chkPrinter);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.txtRecievingPersonName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grdGateInward);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboGate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnF1Help);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGateInwardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGateInward";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gate Inward";
            this.Load += new System.EventHandler(this.frmGateInward_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGateInward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGateInwardNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnF1Help;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView grdGateInward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRecievingPersonName;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.RadioButton optInProcess;
        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalQty;


    }
}