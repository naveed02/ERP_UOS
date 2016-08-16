namespace ERP_UOS
{
    partial class frmReceiveablesPayables
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
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnF1Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountName
            // 
            this.lblAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblAccountName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(201, 62);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(375, 23);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(201, 25);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(239, 21);
            this.txtAccountCode.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(119, 109);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&O.K";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(235, 108);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(111, 23);
            this.btnEscExit.TabIndex = 5;
            this.btnEscExit.Text = "[Esc] = Exit";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnF1Help
            // 
            this.btnF1Help.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1Help.Location = new System.Drawing.Point(352, 109);
            this.btnF1Help.Name = "btnF1Help";
            this.btnF1Help.Size = new System.Drawing.Size(111, 23);
            this.btnF1Help.TabIndex = 6;
            this.btnF1Help.Text = "[F1] = Help";
            this.btnF1Help.UseVisualStyleBackColor = true;
            // 
            // frmReceiveablesPayables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 155);
            this.Controls.Add(this.btnF1Help);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAccountCode);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReceiveablesPayables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receiveables/Payables";
            this.Load += new System.EventHandler(this.frmReceiveablesPayables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnF1Help;
    }
}