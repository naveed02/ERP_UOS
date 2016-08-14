namespace FinanceTransaction
{
    partial class frmAccount_Description
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
            this.msk1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.btnbutton1 = new System.Windows.Forms.Button();
            this.btnbutton2 = new System.Windows.Forms.Button();
            this.btnbutton3 = new System.Windows.Forms.Button();
            this.btnbutton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "  Account Code   ";
            // 
            // msk1
            // 
            this.msk1.Location = new System.Drawing.Point(101, 6);
            this.msk1.Mask = "0-0-00-00-0000";
            this.msk1.Name = "msk1";
            this.msk1.Size = new System.Drawing.Size(122, 21);
            this.msk1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "  Account Name  ";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(101, 33);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(447, 21);
            this.txt1.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(101, 60);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(447, 26);
            this.txt2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "  Account Type    ";
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(120, 94);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(49, 20);
            this.opt1.TabIndex = 6;
            this.opt1.Text = "Detail";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Checked = true;
            this.opt2.Location = new System.Drawing.Point(200, 94);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(52, 20);
            this.opt2.TabIndex = 7;
            this.opt2.TabStop = true;
            this.opt2.Text = "Group";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // btnbutton1
            // 
            this.btnbutton1.Location = new System.Drawing.Point(12, 154);
            this.btnbutton1.Name = "btnbutton1";
            this.btnbutton1.Size = new System.Drawing.Size(75, 73);
            this.btnbutton1.TabIndex = 8;
            this.btnbutton1.Text = "Save";
            this.btnbutton1.UseVisualStyleBackColor = true;
            // 
            // btnbutton2
            // 
            this.btnbutton2.Location = new System.Drawing.Point(101, 154);
            this.btnbutton2.Name = "btnbutton2";
            this.btnbutton2.Size = new System.Drawing.Size(75, 73);
            this.btnbutton2.TabIndex = 9;
            this.btnbutton2.Text = "Delete";
            this.btnbutton2.UseVisualStyleBackColor = true;
            // 
            // btnbutton3
            // 
            this.btnbutton3.Location = new System.Drawing.Point(200, 154);
            this.btnbutton3.Name = "btnbutton3";
            this.btnbutton3.Size = new System.Drawing.Size(75, 73);
            this.btnbutton3.TabIndex = 11;
            this.btnbutton3.Text = "Esc";
            this.btnbutton3.UseVisualStyleBackColor = true;
            // 
            // btnbutton4
            // 
            this.btnbutton4.Location = new System.Drawing.Point(416, 154);
            this.btnbutton4.Name = "btnbutton4";
            this.btnbutton4.Size = new System.Drawing.Size(75, 73);
            this.btnbutton4.TabIndex = 12;
            this.btnbutton4.Text = "[F1]=Help";
            this.btnbutton4.UseVisualStyleBackColor = true;
            // 
            // frmAccount_Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 321);
            this.Controls.Add(this.btnbutton4);
            this.Controls.Add(this.btnbutton3);
            this.Controls.Add(this.btnbutton2);
            this.Controls.Add(this.btnbutton1);
            this.Controls.Add(this.opt2);
            this.Controls.Add(this.opt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk1);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccount_Description";
            this.Text = "Account_Description";
            this.Load += new System.EventHandler(this.frmAccount_Description_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.MaskedTextBox msk1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.Button btnbutton1;
        private System.Windows.Forms.Button btnbutton2;
        private System.Windows.Forms.Button btnbutton3;
        private System.Windows.Forms.Button btnbutton4;
    }
}