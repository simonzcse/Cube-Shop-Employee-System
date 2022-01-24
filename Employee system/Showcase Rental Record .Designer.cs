namespace Employee_system
{
    partial class Showcase_Rental_Record
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
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.cmbStoreID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbShowcase = new System.Windows.Forms.ComboBox();
            this.Showcase = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtrentID = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.txtShowCaseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(1145, 296);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndDate.Multiline = true;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(223, 384);
            this.txtEndDate.TabIndex = 213;
            // 
            // cmbStoreID
            // 
            this.cmbStoreID.FormattingEnabled = true;
            this.cmbStoreID.Items.AddRange(new object[] {
            "840900001",
            "840900002",
            "840900003",
            "840900004",
            "840900005"});
            this.cmbStoreID.Location = new System.Drawing.Point(256, 43);
            this.cmbStoreID.Name = "cmbStoreID";
            this.cmbStoreID.Size = new System.Drawing.Size(340, 26);
            this.cmbStoreID.TabIndex = 202;
            this.cmbStoreID.SelectedIndexChanged += new System.EventHandler(this.cmbStoreID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 201;
            this.label3.Text = "StoreID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbShowcase
            // 
            this.cmbShowcase.FormattingEnabled = true;
            this.cmbShowcase.Location = new System.Drawing.Point(256, 96);
            this.cmbShowcase.Name = "cmbShowcase";
            this.cmbShowcase.Size = new System.Drawing.Size(340, 26);
            this.cmbShowcase.TabIndex = 200;
            this.cmbShowcase.SelectedIndexChanged += new System.EventHandler(this.cmbShowcase_SelectedIndexChanged);
            // 
            // Showcase
            // 
            this.Showcase.AutoSize = true;
            this.Showcase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showcase.Location = new System.Drawing.Point(141, 92);
            this.Showcase.Name = "Showcase";
            this.Showcase.Size = new System.Drawing.Size(107, 27);
            this.Showcase.TabIndex = 199;
            this.Showcase.Text = "Showcase";
            this.Showcase.Click += new System.EventHandler(this.Showcase_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(327, 175);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 52);
            this.btnSearch.TabIndex = 203;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtrentID
            // 
            this.txtrentID.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrentID.Location = new System.Drawing.Point(96, 296);
            this.txtrentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtrentID.Multiline = true;
            this.txtrentID.Name = "txtrentID";
            this.txtrentID.ReadOnly = true;
            this.txtrentID.Size = new System.Drawing.Size(223, 384);
            this.txtrentID.TabIndex = 205;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(132, 230);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(89, 27);
            this.a.TabIndex = 204;
            this.a.Text = "Rent ID";
            // 
            // txtShowCaseID
            // 
            this.txtShowCaseID.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowCaseID.Location = new System.Drawing.Point(388, 296);
            this.txtShowCaseID.Margin = new System.Windows.Forms.Padding(4);
            this.txtShowCaseID.Multiline = true;
            this.txtShowCaseID.Name = "txtShowCaseID";
            this.txtShowCaseID.ReadOnly = true;
            this.txtShowCaseID.Size = new System.Drawing.Size(223, 384);
            this.txtShowCaseID.TabIndex = 207;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 206;
            this.label1.Text = "Show case ID";
            // 
            // txtTenantID
            // 
            this.txtTenantID.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenantID.Location = new System.Drawing.Point(652, 296);
            this.txtTenantID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenantID.Multiline = true;
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.ReadOnly = true;
            this.txtTenantID.Size = new System.Drawing.Size(223, 384);
            this.txtTenantID.TabIndex = 209;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 208;
            this.label2.Text = "Tenant ID";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(901, 296);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDate.Multiline = true;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(223, 384);
            this.txtStartDate.TabIndex = 211;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(950, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 210;
            this.label4.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1210, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 212;
            this.label6.Text = "EndDate";
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(1395, 296);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtFee.Multiline = true;
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(223, 384);
            this.txtFee.TabIndex = 215;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1460, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 27);
            this.label5.TabIndex = 214;
            this.label5.Text = "Fee";
            // 
            // Showcase_Rental_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 737);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenantID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShowCaseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrentID);
            this.Controls.Add(this.a);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbStoreID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbShowcase);
            this.Controls.Add(this.Showcase);
            this.Name = "Showcase_Rental_Record";
            this.Text = "Showcase_Rental_Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStoreID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbShowcase;
        private System.Windows.Forms.Label Showcase;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtrentID;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtShowCaseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label5;
    }
}