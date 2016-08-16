namespace FinanceTransaction
{
    partial class frmCategory
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
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn4 = new System.Windows.Forms.Button();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(16, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "  Category Code  ";
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "1   :  Shift",
            "2   : Godown",
            "3   : Color",
            "4   : Charges",
            "5   : Size",
            "6   : Item Group",
            "7   : Shoe Part",
            "8   : Type",
            "9   : LC",
            "10 : Purpose",
            "11 : Machine No",
            "12 : Contractor",
            "13 : Discount",
            "14 : Add/Transportation",
            "15 : Main Group",
            "16 : Packing",
            "17 : Production Process",
            "18 : Prodution  Status",
            "19 : Prod. Process Part",
            "20 : Gate",
            "21 : Claim Effect",
            "22 : Batch Process Status",
            "23 : Production 2nd Status"});
            this.cbo1.Location = new System.Drawing.Point(112, 23);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(295, 24);
            this.cbo1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 372);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "         Description               ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn3);
            this.groupBox3.Controls.Add(this.btn2);
            this.groupBox3.Controls.Add(this.btn1);
            this.groupBox3.Location = new System.Drawing.Point(45, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(371, 20);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 54);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "  [F1]= Help";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(88, 20);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 54);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "  [Esc]";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(7, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 54);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "  Save";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt3);
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Location = new System.Drawing.Point(133, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(6, 71);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(382, 21);
            this.txt3.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(6, 41);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(382, 21);
            this.txt2.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(6, 14);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "       Urdu Name        ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "            Name           ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(6, 17);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(106, 18);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "            Code            ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn4);
            this.tabPage2.Controls.Add(this.grd1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "               Defined                 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(442, 150);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 54);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "  Esc";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grd1.Location = new System.Drawing.Point(6, 15);
            this.grd1.Name = "grd1";
            this.grd1.Size = new System.Drawing.Size(385, 298);
            this.grd1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = " Name Description";
            this.Column2.Name = "Column2";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 445);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCategory";
            this.Text = "Catagory_Detail_Description";
            this.Load += new System.EventHandler(this.frmCatagory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}