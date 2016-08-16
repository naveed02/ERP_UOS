namespace ERP_UOS
{
    partial class frmGateOutward
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
            this.lblGateOutwardNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnF1Help1 = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnF1Help2 = new System.Windows.Forms.Button();
            this.grdGateOutward = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.optInProcess = new System.Windows.Forms.RadioButton();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.txtReceivingPerson = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdGateOutward)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gate Outward #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Item Group";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGateOutwardNumber
            // 
            this.lblGateOutwardNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGateOutwardNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateOutwardNumber.Location = new System.Drawing.Point(133, 7);
            this.lblGateOutwardNumber.Name = "lblGateOutwardNumber";
            this.lblGateOutwardNumber.Size = new System.Drawing.Size(117, 23);
            this.lblGateOutwardNumber.TabIndex = 2;
            this.lblGateOutwardNumber.Text = "01-16-1";
            this.lblGateOutwardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(702, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(786, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(148, 23);
            this.lblTime.TabIndex = 6;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "&Receiving Person";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Value";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(682, 322);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(252, 23);
            this.lblTotalValue.TabIndex = 9;
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(133, 40);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(168, 23);
            this.cboItemGroup.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(434, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(99, 21);
            this.dtpDate.TabIndex = 11;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(434, 40);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(263, 21);
            this.txtNote.TabIndex = 12;
            // 
            // btnF1Help1
            // 
            this.btnF1Help1.Location = new System.Drawing.Point(541, 7);
            this.btnF1Help1.Name = "btnF1Help1";
            this.btnF1Help1.Size = new System.Drawing.Size(90, 23);
            this.btnF1Help1.TabIndex = 13;
            this.btnF1Help1.Text = "F1=Help";
            this.btnF1Help1.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(639, 7);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(99, 23);
            this.btnAddNew.TabIndex = 14;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnF1Help2
            // 
            this.btnF1Help2.Location = new System.Drawing.Point(745, 7);
            this.btnF1Help2.Name = "btnF1Help2";
            this.btnF1Help2.Size = new System.Drawing.Size(92, 23);
            this.btnF1Help2.TabIndex = 15;
            this.btnF1Help2.Text = "F1=Help";
            this.btnF1Help2.UseVisualStyleBackColor = true;
            // 
            // grdGateOutward
            // 
            this.grdGateOutward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGateOutward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column1,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column15,
            this.Column17,
            this.Column18});
            this.grdGateOutward.Location = new System.Drawing.Point(10, 69);
            this.grdGateOutward.Name = "grdGateOutward";
            this.grdGateOutward.Size = new System.Drawing.Size(924, 247);
            this.grdGateOutward.TabIndex = 38;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Code";
            this.Column7.Name = "Column7";
            this.Column7.Width = 40;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Item Code";
            this.Column8.Name = "Column8";
            this.Column8.Width = 90;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Name";
            this.Column9.Name = "Column9";
            this.Column9.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Size";
            this.Column10.Name = "Column10";
            this.Column10.Width = 70;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Colour";
            this.Column11.Name = "Column11";
            this.Column11.Width = 70;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "UOM";
            this.Column12.Name = "Column12";
            this.Column12.Width = 70;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Godown";
            this.Column13.Name = "Column13";
            this.Column13.Width = 80;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Qty";
            this.Column15.Name = "Column15";
            this.Column15.Width = 80;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Rate";
            this.Column17.Name = "Column17";
            this.Column17.Width = 80;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Amount";
            this.Column18.Name = "Column18";
            this.Column18.Width = 90;
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Location = new System.Drawing.Point(414, 326);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(119, 19);
            this.optApprovedVerified.TabIndex = 44;
            this.optApprovedVerified.Text = "Approved/Verified";
            this.optApprovedVerified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            // 
            // optInProcess
            // 
            this.optInProcess.AutoSize = true;
            this.optInProcess.Checked = true;
            this.optInProcess.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInProcess.Location = new System.Drawing.Point(320, 326);
            this.optInProcess.Name = "optInProcess";
            this.optInProcess.Size = new System.Drawing.Size(84, 19);
            this.optInProcess.TabIndex = 43;
            this.optInProcess.TabStop = true;
            this.optInProcess.Text = "In Process";
            this.optInProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optInProcess.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(187, 322);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(97, 23);
            this.btnEscExit.TabIndex = 41;
            this.btnEscExit.Text = "< Esc = Exit >";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(10, 322);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(84, 23);
            this.btnExitSave.TabIndex = 40;
            this.btnExitSave.Text = "E&xit+Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(100, 322);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(81, 23);
            this.btnPrinting.TabIndex = 39;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // txtReceivingPerson
            // 
            this.txtReceivingPerson.Location = new System.Drawing.Point(554, 350);
            this.txtReceivingPerson.Name = "txtReceivingPerson";
            this.txtReceivingPerson.Size = new System.Drawing.Size(380, 21);
            this.txtReceivingPerson.TabIndex = 45;
            // 
            // frmGateOutward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 385);
            this.Controls.Add(this.txtReceivingPerson);
            this.Controls.Add(this.optApprovedVerified);
            this.Controls.Add(this.optInProcess);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.grdGateOutward);
            this.Controls.Add(this.btnF1Help2);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnF1Help1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGateOutwardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGateOutward";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GateOutward";
            this.Load += new System.EventHandler(this.frmGateOutward_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGateOutward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGateOutwardNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnF1Help1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnF1Help2;
        private System.Windows.Forms.DataGridView grdGateOutward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column10;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column11;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column12;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.RadioButton optInProcess;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.TextBox txtReceivingPerson;
    }
}