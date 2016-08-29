namespace ERP_UOS
{
    partial class frmCash
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.optCashStatement = new System.Windows.Forms.RadioButton();
            this.optCashRoker = new System.Windows.Forms.RadioButton();
            this.optBankStatement = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdCashStatement = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReceipts = new System.Windows.Forms.TextBox();
            this.txtPayments = new System.Windows.Forms.TextBox();
            this.txtNetBalance = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = " From Date  ";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(88, 16);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(122, 21);
            this.dtp1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "    To Date    ";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(297, 15);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(111, 21);
            this.dtp2.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(414, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "[Esc]=Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnPrinting
            // 
            this.btnPrinting.Location = new System.Drawing.Point(562, 14);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(75, 23);
            this.btnPrinting.TabIndex = 6;
            this.btnPrinting.Text = " Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // optCashStatement
            // 
            this.optCashStatement.AutoSize = true;
            this.optCashStatement.Checked = true;
            this.optCashStatement.Location = new System.Drawing.Point(667, 12);
            this.optCashStatement.Name = "optCashStatement";
            this.optCashStatement.Size = new System.Drawing.Size(114, 19);
            this.optCashStatement.TabIndex = 7;
            this.optCashStatement.TabStop = true;
            this.optCashStatement.Text = "Cash Statement";
            this.optCashStatement.UseVisualStyleBackColor = true;
            // 
            // optCashRoker
            // 
            this.optCashRoker.AutoSize = true;
            this.optCashRoker.Location = new System.Drawing.Point(667, 30);
            this.optCashRoker.Name = "optCashRoker";
            this.optCashRoker.Size = new System.Drawing.Size(91, 19);
            this.optCashRoker.TabIndex = 8;
            this.optCashRoker.Text = "Cash Roker";
            this.optCashRoker.UseVisualStyleBackColor = true;
            // 
            // optBankStatement
            // 
            this.optBankStatement.AutoSize = true;
            this.optBankStatement.Location = new System.Drawing.Point(667, 46);
            this.optBankStatement.Name = "optBankStatement";
            this.optBankStatement.Size = new System.Drawing.Size(145, 19);
            this.optBankStatement.TabIndex = 9;
            this.optBankStatement.Text = "Cash/Bank Statement";
            this.optBankStatement.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.optBankStatement);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.optCashRoker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.optCashStatement);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.btnPrinting);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grdCashStatement
            // 
            this.grdCashStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCashStatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grdCashStatement.Location = new System.Drawing.Point(10, 81);
            this.grdCashStatement.Name = "grdCashStatement";
            this.grdCashStatement.Size = new System.Drawing.Size(808, 159);
            this.grdCashStatement.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Voc.No.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Account";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Receipts";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Payments";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Details";
            this.Column6.Name = "Column6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = " Opening Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "        Payments   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(626, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "      Net Balance  ";
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Location = new System.Drawing.Point(182, 274);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(145, 21);
            this.txtOpeningBalance.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "      Receipts       ";
            // 
            // txtReceipts
            // 
            this.txtReceipts.Location = new System.Drawing.Point(335, 274);
            this.txtReceipts.Name = "txtReceipts";
            this.txtReceipts.Size = new System.Drawing.Size(140, 21);
            this.txtReceipts.TabIndex = 18;
            // 
            // txtPayments
            // 
            this.txtPayments.Location = new System.Drawing.Point(481, 274);
            this.txtPayments.Name = "txtPayments";
            this.txtPayments.Size = new System.Drawing.Size(140, 21);
            this.txtPayments.TabIndex = 19;
            // 
            // txtNetBalance
            // 
            this.txtNetBalance.Location = new System.Drawing.Point(626, 274);
            this.txtNetBalance.Name = "txtNetBalance";
            this.txtNetBalance.Size = new System.Drawing.Size(140, 21);
            this.txtNetBalance.TabIndex = 20;
            // 
            // frmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 302);
            this.Controls.Add(this.txtNetBalance);
            this.Controls.Add(this.txtPayments);
            this.Controls.Add(this.txtReceipts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOpeningBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdCashStatement);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCash";
            this.Text = "Cash Statement";
            this.Load += new System.EventHandler(this.frmCash_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.RadioButton optCashStatement;
        private System.Windows.Forms.RadioButton optCashRoker;
        private System.Windows.Forms.RadioButton optBankStatement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdCashStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReceipts;
        private System.Windows.Forms.TextBox txtPayments;
        private System.Windows.Forms.TextBox txtNetBalance;
    }
}