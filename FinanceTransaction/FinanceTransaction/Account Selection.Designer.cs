namespace FinanceTransaction
{
    partial class Account_Selection
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "  Name   ";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(69, 10);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(226, 21);
            this.txt1.TabIndex = 96;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(429, 10);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 28);
            this.btn2.TabIndex = 97;
            this.btn2.Text = "  O.K  ";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(313, 12);
            this.opt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(47, 20);
            this.opt1.TabIndex = 98;
            this.opt1.TabStop = true;
            this.opt1.Text = "Initial";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(366, 11);
            this.opt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(52, 20);
            this.opt2.TabIndex = 99;
            this.opt2.TabStop = true;
            this.opt2.Text = "Match";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grd1.Location = new System.Drawing.Point(12, 46);
            this.grd1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd1.Name = "grd1";
            this.grd1.Size = new System.Drawing.Size(485, 250);
            this.grd1.TabIndex = 100;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Account Discription                                 ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Code       ";
            this.Column2.Name = "Column2";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 329);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(310, 23);
            this.btn1.TabIndex = 101;
            this.btn1.Text = "              <<<[Esc]= Return Back>>>";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // Account_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 401);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.grd1);
            this.Controls.Add(this.opt2);
            this.Controls.Add(this.opt1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Account_Selection";
            this.Text = "Account_Selection";
            this.Load += new System.EventHandler(this.Account_Selection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn1;
    }
}