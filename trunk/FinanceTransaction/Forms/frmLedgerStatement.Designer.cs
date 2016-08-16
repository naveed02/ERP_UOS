namespace ERP_UOS
{
    partial class frmLedgerStatement
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblOpBal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPostDatedCheque = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDebit = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnWODishChq = new System.Windows.Forms.Button();
            this.btnChemCont = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShoePO = new System.Windows.Forms.Button();
            this.btnShoeOrd = new System.Windows.Forms.Button();
            this.btnChemPC = new System.Windows.Forms.Button();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.optEnglish = new System.Windows.Forms.RadioButton();
            this.optUrdu = new System.Windows.Forms.RadioButton();
            this.optSummary = new System.Windows.Forms.RadioButton();
            this.optQtyLedger = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "From Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "To Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone #";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Credit Limit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreditLimit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditLimit.Location = new System.Drawing.Point(114, 126);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(177, 23);
            this.lblCreditLimit.TabIndex = 5;
            this.lblCreditLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Balance";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Op. Bal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(393, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(336, 23);
            this.lblName.TabIndex = 9;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(393, 36);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(189, 23);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpBal
            // 
            this.lblOpBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblOpBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpBal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpBal.Location = new System.Drawing.Point(393, 66);
            this.lblOpBal.Name = "lblOpBal";
            this.lblOpBal.Size = new System.Drawing.Size(189, 23);
            this.lblOpBal.TabIndex = 11;
            this.lblOpBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 518);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 27);
            this.label13.TabIndex = 12;
            this.label13.Text = "Post Dated Cheque";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPostDatedCheque
            // 
            this.lblPostDatedCheque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPostDatedCheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostDatedCheque.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostDatedCheque.Location = new System.Drawing.Point(132, 518);
            this.lblPostDatedCheque.Name = "lblPostDatedCheque";
            this.lblPostDatedCheque.Size = new System.Drawing.Size(218, 27);
            this.lblPostDatedCheque.TabIndex = 13;
            this.lblPostDatedCheque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(365, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 27);
            this.label15.TabIndex = 14;
            this.label15.Text = "Debit";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDebit
            // 
            this.lblDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDebit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebit.Location = new System.Drawing.Point(414, 518);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(210, 27);
            this.lblDebit.TabIndex = 15;
            this.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(642, 518);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 27);
            this.label17.TabIndex = 16;
            this.label17.Text = "Credit";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCredit
            // 
            this.lblCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCredit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(698, 518);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(199, 27);
            this.lblCredit.TabIndex = 17;
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(114, 7);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(188, 21);
            this.txtAccountCode.TabIndex = 18;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(114, 36);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(137, 21);
            this.dtpFromDate.TabIndex = 22;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(114, 66);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(137, 21);
            this.dtpToDate.TabIndex = 23;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(114, 96);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(468, 21);
            this.txtPhoneNumber.TabIndex = 24;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(260, 36);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(43, 54);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "&O.K";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(588, 36);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(51, 23);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(642, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(588, 66);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(105, 23);
            this.btnEscExit.TabIndex = 28;
            this.btnEscExit.Text = "[Esc] = Exit";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click_1);
            // 
            // btnWODishChq
            // 
            this.btnWODishChq.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWODishChq.Location = new System.Drawing.Point(588, 96);
            this.btnWODishChq.Name = "btnWODishChq";
            this.btnWODishChq.Size = new System.Drawing.Size(105, 23);
            this.btnWODishChq.TabIndex = 29;
            this.btnWODishChq.Text = "WO Dish Chq";
            this.btnWODishChq.UseVisualStyleBackColor = true;
            // 
            // btnChemCont
            // 
            this.btnChemCont.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChemCont.Location = new System.Drawing.Point(735, 7);
            this.btnChemCont.Name = "btnChemCont";
            this.btnChemCont.Size = new System.Drawing.Size(162, 23);
            this.btnChemCont.TabIndex = 30;
            this.btnChemCont.Text = "C&hem Cont.";
            this.btnChemCont.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(698, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(199, 113);
            this.dataGridView1.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Brand Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.Name = "Column2";
            // 
            // btnShoePO
            // 
            this.btnShoePO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoePO.Location = new System.Drawing.Point(297, 126);
            this.btnShoePO.Name = "btnShoePO";
            this.btnShoePO.Size = new System.Drawing.Size(75, 23);
            this.btnShoePO.TabIndex = 32;
            this.btnShoePO.Text = "Shoe &P.O";
            this.btnShoePO.UseVisualStyleBackColor = true;
            // 
            // btnShoeOrd
            // 
            this.btnShoeOrd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoeOrd.Location = new System.Drawing.Point(375, 126);
            this.btnShoeOrd.Name = "btnShoeOrd";
            this.btnShoeOrd.Size = new System.Drawing.Size(75, 23);
            this.btnShoeOrd.TabIndex = 33;
            this.btnShoeOrd.Text = "&Shoe Ord";
            this.btnShoeOrd.UseVisualStyleBackColor = true;
            // 
            // btnChemPC
            // 
            this.btnChemPC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChemPC.Location = new System.Drawing.Point(452, 126);
            this.btnChemPC.Name = "btnChemPC";
            this.btnChemPC.Size = new System.Drawing.Size(75, 23);
            this.btnChemPC.TabIndex = 34;
            this.btnChemPC.Text = "&Chem P.C";
            this.btnChemPC.UseVisualStyleBackColor = true;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(529, 126);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(75, 23);
            this.btnPrinting.TabIndex = 35;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // optEnglish
            // 
            this.optEnglish.AutoSize = true;
            this.optEnglish.Checked = true;
            this.optEnglish.Location = new System.Drawing.Point(610, 124);
            this.optEnglish.Name = "optEnglish";
            this.optEnglish.Size = new System.Drawing.Size(67, 19);
            this.optEnglish.TabIndex = 36;
            this.optEnglish.TabStop = true;
            this.optEnglish.Text = "&English";
            this.optEnglish.UseVisualStyleBackColor = true;
            // 
            // optUrdu
            // 
            this.optUrdu.AutoSize = true;
            this.optUrdu.Location = new System.Drawing.Point(610, 146);
            this.optUrdu.Name = "optUrdu";
            this.optUrdu.Size = new System.Drawing.Size(52, 19);
            this.optUrdu.TabIndex = 37;
            this.optUrdu.Text = "&Urdu";
            this.optUrdu.UseVisualStyleBackColor = true;
            // 
            // optSummary
            // 
            this.optSummary.AutoSize = true;
            this.optSummary.Location = new System.Drawing.Point(610, 167);
            this.optSummary.Name = "optSummary";
            this.optSummary.Size = new System.Drawing.Size(78, 19);
            this.optSummary.TabIndex = 38;
            this.optSummary.Text = "&Summary";
            this.optSummary.UseVisualStyleBackColor = true;
            // 
            // optQtyLedger
            // 
            this.optQtyLedger.AutoSize = true;
            this.optQtyLedger.Location = new System.Drawing.Point(520, 167);
            this.optQtyLedger.Name = "optQtyLedger";
            this.optQtyLedger.Size = new System.Drawing.Size(84, 19);
            this.optQtyLedger.TabIndex = 39;
            this.optQtyLedger.Text = "&Qty Ledger";
            this.optQtyLedger.UseVisualStyleBackColor = true;
            // 
            // frmLedgerStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.optQtyLedger);
            this.Controls.Add(this.optSummary);
            this.Controls.Add(this.optUrdu);
            this.Controls.Add(this.optEnglish);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnChemPC);
            this.Controls.Add(this.btnShoeOrd);
            this.Controls.Add(this.btnShoePO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChemCont);
            this.Controls.Add(this.btnWODishChq);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtAccountCode);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblDebit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblPostDatedCheque);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblOpBal);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCreditLimit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLedgerStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger Statement";
            this.Load += new System.EventHandler(this.frmLedgerStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblOpBal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPostDatedCheque;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnWODishChq;
        private System.Windows.Forms.Button btnChemCont;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnShoePO;
        private System.Windows.Forms.Button btnShoeOrd;
        private System.Windows.Forms.Button btnChemPC;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.RadioButton optEnglish;
        private System.Windows.Forms.RadioButton optUrdu;
        private System.Windows.Forms.RadioButton optSummary;
        private System.Windows.Forms.RadioButton optQtyLedger;
    }
}