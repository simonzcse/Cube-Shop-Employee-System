namespace Employee_system
{
    partial class Update_Tenant
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
            this.txtNew = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPhone = new System.Windows.Forms.RadioButton();
            this.rdoAddress = new System.Windows.Forms.RadioButton();
            this.rdoEmail = new System.Windows.Forms.RadioButton();
            this.rdoUserName = new System.Windows.Forms.RadioButton();
            this.rdoPassword = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.Location = new System.Drawing.Point(279, 374);
            this.txtNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtNew.Multiline = true;
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(482, 73);
            this.txtNew.TabIndex = 183;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 80);
            this.button1.TabIndex = 181;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTID
            // 
            this.txtTID.Enabled = false;
            this.txtTID.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTID.Location = new System.Drawing.Point(279, 102);
            this.txtTID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTID.Multiline = true;
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(482, 73);
            this.txtTID.TabIndex = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 51);
            this.label2.TabIndex = 179;
            this.label2.Text = "Update Tenant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 46);
            this.label4.TabIndex = 178;
            this.label4.Text = "Tenant ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 46);
            this.label1.TabIndex = 184;
            this.label1.Text = "New:";
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(13, 28);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(74, 22);
            this.rdoName.TabIndex = 185;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoName_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPassword);
            this.groupBox1.Controls.Add(this.rdoUserName);
            this.groupBox1.Controls.Add(this.rdoEmail);
            this.groupBox1.Controls.Add(this.rdoAddress);
            this.groupBox1.Controls.Add(this.rdoPhone);
            this.groupBox1.Controls.Add(this.rdoName);
            this.groupBox1.Location = new System.Drawing.Point(279, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 127);
            this.groupBox1.TabIndex = 186;
            this.groupBox1.TabStop = false;
            // 
            // rdoPhone
            // 
            this.rdoPhone.AutoSize = true;
            this.rdoPhone.Location = new System.Drawing.Point(158, 28);
            this.rdoPhone.Name = "rdoPhone";
            this.rdoPhone.Size = new System.Drawing.Size(74, 22);
            this.rdoPhone.TabIndex = 186;
            this.rdoPhone.TabStop = true;
            this.rdoPhone.Text = "Phone";
            this.rdoPhone.UseVisualStyleBackColor = true;
            this.rdoPhone.CheckedChanged += new System.EventHandler(this.rdoPhone_CheckedChanged);
            // 
            // rdoAddress
            // 
            this.rdoAddress.AutoSize = true;
            this.rdoAddress.Location = new System.Drawing.Point(313, 28);
            this.rdoAddress.Name = "rdoAddress";
            this.rdoAddress.Size = new System.Drawing.Size(89, 22);
            this.rdoAddress.TabIndex = 187;
            this.rdoAddress.TabStop = true;
            this.rdoAddress.Text = "Address";
            this.rdoAddress.UseVisualStyleBackColor = true;
            this.rdoAddress.CheckedChanged += new System.EventHandler(this.rdoAddress_CheckedChanged);
            // 
            // rdoEmail
            // 
            this.rdoEmail.AutoSize = true;
            this.rdoEmail.Location = new System.Drawing.Point(313, 77);
            this.rdoEmail.Name = "rdoEmail";
            this.rdoEmail.Size = new System.Drawing.Size(74, 22);
            this.rdoEmail.TabIndex = 188;
            this.rdoEmail.TabStop = true;
            this.rdoEmail.Text = "Email";
            this.rdoEmail.UseVisualStyleBackColor = true;
            this.rdoEmail.CheckedChanged += new System.EventHandler(this.rdoEmail_CheckedChanged);
            // 
            // rdoUserName
            // 
            this.rdoUserName.AutoSize = true;
            this.rdoUserName.Location = new System.Drawing.Point(13, 77);
            this.rdoUserName.Name = "rdoUserName";
            this.rdoUserName.Size = new System.Drawing.Size(112, 22);
            this.rdoUserName.TabIndex = 189;
            this.rdoUserName.TabStop = true;
            this.rdoUserName.Text = "User Name";
            this.rdoUserName.UseVisualStyleBackColor = true;
            this.rdoUserName.CheckedChanged += new System.EventHandler(this.rdoUserName_CheckedChanged);
            // 
            // rdoPassword
            // 
            this.rdoPassword.AutoSize = true;
            this.rdoPassword.Location = new System.Drawing.Point(157, 77);
            this.rdoPassword.Name = "rdoPassword";
            this.rdoPassword.Size = new System.Drawing.Size(98, 22);
            this.rdoPassword.TabIndex = 190;
            this.rdoPassword.TabStop = true;
            this.rdoPassword.Text = "Password";
            this.rdoPassword.UseVisualStyleBackColor = true;
            this.rdoPassword.CheckedChanged += new System.EventHandler(this.rdoPassword_CheckedChanged);
            // 
            // Update_Tenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Update_Tenant";
            this.Text = "Update_Tenant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPassword;
        private System.Windows.Forms.RadioButton rdoUserName;
        private System.Windows.Forms.RadioButton rdoEmail;
        private System.Windows.Forms.RadioButton rdoAddress;
        private System.Windows.Forms.RadioButton rdoPhone;
    }
}