namespace FinanceTransaction
{
    partial class frmGroup
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
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.bu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "      Item Group     ";
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "-",
            "BUCKLE",
            "CHEMICAL PU",
            "EVA SHOES",
            "GENRAL",
            "LEATHER AND REXINE",
            "PCU SHOES",
            "PPC PATAWA CUTTING",
            "PPU PRINT PATAWA",
            "PUD STOR DEPARTMENT",
            "PUS SHOES",
            "REXINE MATERIAL",
            "SCRAPE",
            "PUC UPPER CUTTING",
            "UPS UPPER SEWING"});
            this.cbo1.Location = new System.Drawing.Point(121, 6);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(312, 23);
            this.cbo1.TabIndex = 1;
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grd1.Location = new System.Drawing.Point(12, 35);
            this.grd1.Name = "grd1";
            this.grd1.Size = new System.Drawing.Size(421, 158);
            this.grd1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "   SIZE";
            this.Column1.Name = "Column1";
            // 
            // grid2
            // 
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.grid2.Location = new System.Drawing.Point(12, 199);
            this.grid2.Name = "grid2";
            this.grid2.Size = new System.Drawing.Size(421, 176);
            this.grid2.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Color";
            this.Column2.Name = "Column2";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 381);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(88, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Select All";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(106, 381);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(113, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Unselected All";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(225, 381);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(88, 23);
            this.btn3.TabIndex = 6;
            this.btn3.Text = " Exit+Save";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // bu
            // 
            this.bu.Location = new System.Drawing.Point(337, 381);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(96, 23);
            this.bu.TabIndex = 7;
            this.bu.Text = "< Esc=Exit >";
            this.bu.UseVisualStyleBackColor = true;
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 420);
            this.Controls.Add(this.bu);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grd1);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGroup";
            this.Text = "Group_Size_Color_Selection";
            this.Load += new System.EventHandler(this.frmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button bu;
    }
}