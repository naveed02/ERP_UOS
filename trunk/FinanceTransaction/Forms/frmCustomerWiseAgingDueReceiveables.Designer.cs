namespace Enterprise_Resource_Planning
{
    partial class frmCustomerWiseAgingDueReceiveables
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
            this.btnF1Help = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optWithDishonouredCheques = new System.Windows.Forms.RadioButton();
            this.optWithoutDishonouredCheques = new System.Windows.Forms.RadioButton();
            this.optCrDaysWithoutDishonouredCheques = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnF1Help
            // 
            this.btnF1Help.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1Help.Location = new System.Drawing.Point(395, 200);
            this.btnF1Help.Name = "btnF1Help";
            this.btnF1Help.Size = new System.Drawing.Size(129, 23);
            this.btnF1Help.TabIndex = 20;
            this.btnF1Help.Text = "[F1] = Help";
            this.btnF1Help.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(259, 199);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(129, 23);
            this.btnEscExit.TabIndex = 19;
            this.btnEscExit.Text = "[Esc] = Exit";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(123, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "&O.K";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(219, 18);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(278, 21);
            this.txtAccountCode.TabIndex = 17;
            // 
            // lblAccountName
            // 
            this.lblAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblAccountName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(219, 54);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(397, 23);
            this.lblAccountName.TabIndex = 16;
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Account Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Account Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optWithDishonouredCheques
            // 
            this.optWithDishonouredCheques.AutoSize = true;
            this.optWithDishonouredCheques.Location = new System.Drawing.Point(219, 99);
            this.optWithDishonouredCheques.Name = "optWithDishonouredCheques";
            this.optWithDishonouredCheques.Size = new System.Drawing.Size(178, 19);
            this.optWithDishonouredCheques.TabIndex = 21;
            this.optWithDishonouredCheques.TabStop = true;
            this.optWithDishonouredCheques.Text = "With Dishonoured Cheques";
            this.optWithDishonouredCheques.UseVisualStyleBackColor = true;
            // 
            // optWithoutDishonouredCheques
            // 
            this.optWithoutDishonouredCheques.AutoSize = true;
            this.optWithoutDishonouredCheques.Location = new System.Drawing.Point(219, 128);
            this.optWithoutDishonouredCheques.Name = "optWithoutDishonouredCheques";
            this.optWithoutDishonouredCheques.Size = new System.Drawing.Size(195, 19);
            this.optWithoutDishonouredCheques.TabIndex = 22;
            this.optWithoutDishonouredCheques.TabStop = true;
            this.optWithoutDishonouredCheques.Text = "Without Dishonoured Cheques";
            this.optWithoutDishonouredCheques.UseVisualStyleBackColor = true;
            // 
            // optCrDaysWithoutDishonouredCheques
            // 
            this.optCrDaysWithoutDishonouredCheques.AutoSize = true;
            this.optCrDaysWithoutDishonouredCheques.Location = new System.Drawing.Point(219, 156);
            this.optCrDaysWithoutDishonouredCheques.Name = "optCrDaysWithoutDishonouredCheques";
            this.optCrDaysWithoutDishonouredCheques.Size = new System.Drawing.Size(241, 19);
            this.optCrDaysWithoutDishonouredCheques.TabIndex = 23;
            this.optCrDaysWithoutDishonouredCheques.TabStop = true;
            this.optCrDaysWithoutDishonouredCheques.Text = "Cr.Days Without Dishonoured Cheques";
            this.optCrDaysWithoutDishonouredCheques.UseVisualStyleBackColor = true;
            // 
            // frmCustomerWiseAgingDueReceiveables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 245);
            this.Controls.Add(this.optCrDaysWithoutDishonouredCheques);
            this.Controls.Add(this.optWithoutDishonouredCheques);
            this.Controls.Add(this.optWithDishonouredCheques);
            this.Controls.Add(this.btnF1Help);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAccountCode);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCustomerWiseAgingDueReceiveables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Wise Aging/Due Receiveables";
            this.Load += new System.EventHandler(this.frmCustomerWiseAgingDueReceiveables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnF1Help;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optWithDishonouredCheques;
        private System.Windows.Forms.RadioButton optWithoutDishonouredCheques;
        private System.Windows.Forms.RadioButton optCrDaysWithoutDishonouredCheques;
    }
}