namespace Employee_system
{
    partial class Main_menu
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
            this.btnInstoring = new System.Windows.Forms.Button();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSaling = new System.Windows.Forms.Button();
            this.btnItemInfomation = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTakingItem = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnShowcaseList = new System.Windows.Forms.Button();
            this.btnStaffList = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnShowcaseSalesRecord = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnRentShowcase = new System.Windows.Forms.Button();
            this.btnMonStatement = new System.Windows.Forms.Button();
            this.StaffManangement = new System.Windows.Forms.GroupBox();
            this.btnNewStaff = new System.Windows.Forms.Button();
            this.btnTList = new System.Windows.Forms.Button();
            this.btnPastTimeRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnViewSelf = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.grpItem.SuspendLayout();
            this.StaffManangement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstoring
            // 
            this.btnInstoring.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstoring.Location = new System.Drawing.Point(60, 222);
            this.btnInstoring.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstoring.Name = "btnInstoring";
            this.btnInstoring.Size = new System.Drawing.Size(224, 98);
            this.btnInstoring.TabIndex = 0;
            this.btnInstoring.Text = "Restocking\rItem";
            this.btnInstoring.UseVisualStyleBackColor = true;
            this.btnInstoring.Click += new System.EventHandler(this.btnInstoring_Click);
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.button5);
            this.grpItem.Controls.Add(this.btnSaling);
            this.grpItem.Controls.Add(this.btnItemInfomation);
            this.grpItem.Controls.Add(this.btnInstoring);
            this.grpItem.Controls.Add(this.btnNewItem);
            this.grpItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpItem.Location = new System.Drawing.Point(18, 80);
            this.grpItem.Margin = new System.Windows.Forms.Padding(4);
            this.grpItem.Name = "grpItem";
            this.grpItem.Padding = new System.Windows.Forms.Padding(4);
            this.grpItem.Size = new System.Drawing.Size(906, 404);
            this.grpItem.TabIndex = 1;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item";
            this.grpItem.Enter += new System.EventHandler(this.grpItem_Enter);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(627, 54);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 98);
            this.button5.TabIndex = 36;
            this.button5.Text = "Find Sales Record by Order";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnSaling
            // 
            this.btnSaling.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaling.Location = new System.Drawing.Point(350, 54);
            this.btnSaling.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaling.Name = "btnSaling";
            this.btnSaling.Size = new System.Drawing.Size(224, 98);
            this.btnSaling.TabIndex = 2;
            this.btnSaling.Text = "Saling";
            this.btnSaling.UseVisualStyleBackColor = true;
            this.btnSaling.Click += new System.EventHandler(this.btnSaling_Click);
            // 
            // btnItemInfomation
            // 
            this.btnItemInfomation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemInfomation.Location = new System.Drawing.Point(350, 222);
            this.btnItemInfomation.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemInfomation.Name = "btnItemInfomation";
            this.btnItemInfomation.Size = new System.Drawing.Size(224, 98);
            this.btnItemInfomation.TabIndex = 1;
            this.btnItemInfomation.Text = "Find Item Infomation";
            this.btnItemInfomation.UseVisualStyleBackColor = true;
            this.btnItemInfomation.Click += new System.EventHandler(this.btnItemInfomation_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItem.Location = new System.Drawing.Point(60, 54);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(224, 98);
            this.btnNewItem.TabIndex = 35;
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.button32_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2360, 915);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 98);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Case";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTakingItem
            // 
            this.btnTakingItem.Location = new System.Drawing.Point(2360, 1032);
            this.btnTakingItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTakingItem.Name = "btnTakingItem";
            this.btnTakingItem.Size = new System.Drawing.Size(224, 98);
            this.btnTakingItem.TabIndex = 3;
            this.btnTakingItem.Text = "Taking Item";
            this.btnTakingItem.UseVisualStyleBackColor = true;
            this.btnTakingItem.Click += new System.EventHandler(this.btnTakingItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(18, 22);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 52);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logined as:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(408, 38);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(128, 34);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "[position]";
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // btnShowcaseList
            // 
            this.btnShowcaseList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowcaseList.Location = new System.Drawing.Point(72, 105);
            this.btnShowcaseList.Name = "btnShowcaseList";
            this.btnShowcaseList.Size = new System.Drawing.Size(224, 98);
            this.btnShowcaseList.TabIndex = 6;
            this.btnShowcaseList.Text = "Showcase list";
            this.btnShowcaseList.UseVisualStyleBackColor = true;
            this.btnShowcaseList.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStaffList
            // 
            this.btnStaffList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffList.Location = new System.Drawing.Point(38, 232);
            this.btnStaffList.Name = "btnStaffList";
            this.btnStaffList.Size = new System.Drawing.Size(224, 86);
            this.btnStaffList.TabIndex = 11;
            this.btnStaffList.Text = "Staff list";
            this.btnStaffList.UseVisualStyleBackColor = true;
            this.btnStaffList.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.Location = new System.Drawing.Point(333, 232);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(224, 98);
            this.btnDeleteStaff.TabIndex = 12;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(333, 76);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(224, 98);
            this.btnUpdateStaff.TabIndex = 13;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(38, 76);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(224, 98);
            this.btnCal.TabIndex = 14;
            this.btnCal.Text = "Cal Salary";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnShowcaseSalesRecord
            // 
            this.btnShowcaseSalesRecord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowcaseSalesRecord.Location = new System.Drawing.Point(442, 270);
            this.btnShowcaseSalesRecord.Name = "btnShowcaseSalesRecord";
            this.btnShowcaseSalesRecord.Size = new System.Drawing.Size(224, 98);
            this.btnShowcaseSalesRecord.TabIndex = 16;
            this.btnShowcaseSalesRecord.Text = "Showcase Sales Record";
            this.btnShowcaseSalesRecord.UseVisualStyleBackColor = true;
            this.btnShowcaseSalesRecord.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(72, 270);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(224, 98);
            this.btnReserve.TabIndex = 20;
            this.btnReserve.Text = "Reserve Showcase";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // btnRentShowcase
            // 
            this.btnRentShowcase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentShowcase.Location = new System.Drawing.Point(442, 105);
            this.btnRentShowcase.Name = "btnRentShowcase";
            this.btnRentShowcase.Size = new System.Drawing.Size(224, 98);
            this.btnRentShowcase.TabIndex = 29;
            this.btnRentShowcase.Text = "Rent showcase";
            this.btnRentShowcase.UseVisualStyleBackColor = true;
            this.btnRentShowcase.Click += new System.EventHandler(this.button26_Click_1);
            // 
            // btnMonStatement
            // 
            this.btnMonStatement.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonStatement.Location = new System.Drawing.Point(78, 54);
            this.btnMonStatement.Name = "btnMonStatement";
            this.btnMonStatement.Size = new System.Drawing.Size(224, 98);
            this.btnMonStatement.TabIndex = 30;
            this.btnMonStatement.Text = "Monthly Statement";
            this.btnMonStatement.UseVisualStyleBackColor = true;
            this.btnMonStatement.Click += new System.EventHandler(this.button27_Click);
            // 
            // StaffManangement
            // 
            this.StaffManangement.Controls.Add(this.btnNewStaff);
            this.StaffManangement.Controls.Add(this.btnTList);
            this.StaffManangement.Controls.Add(this.btnPastTimeRecord);
            this.StaffManangement.Controls.Add(this.btnCal);
            this.StaffManangement.Controls.Add(this.btnStaffList);
            this.StaffManangement.Controls.Add(this.btnDeleteStaff);
            this.StaffManangement.Controls.Add(this.btnUpdateStaff);
            this.StaffManangement.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffManangement.Location = new System.Drawing.Point(12, 506);
            this.StaffManangement.Name = "StaffManangement";
            this.StaffManangement.Size = new System.Drawing.Size(912, 440);
            this.StaffManangement.TabIndex = 36;
            this.StaffManangement.TabStop = false;
            this.StaffManangement.Text = "Staff Manangement";
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.Location = new System.Drawing.Point(38, 339);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(224, 78);
            this.btnNewStaff.TabIndex = 43;
            this.btnNewStaff.Text = "New Staff";
            this.btnNewStaff.UseVisualStyleBackColor = true;
            this.btnNewStaff.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnTList
            // 
            this.btnTList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTList.Location = new System.Drawing.Point(614, 232);
            this.btnTList.Name = "btnTList";
            this.btnTList.Size = new System.Drawing.Size(224, 98);
            this.btnTList.TabIndex = 16;
            this.btnTList.Text = "Tenant List";
            this.btnTList.UseVisualStyleBackColor = true;
            this.btnTList.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPastTimeRecord
            // 
            this.btnPastTimeRecord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastTimeRecord.Location = new System.Drawing.Point(614, 76);
            this.btnPastTimeRecord.Name = "btnPastTimeRecord";
            this.btnPastTimeRecord.Size = new System.Drawing.Size(243, 98);
            this.btnPastTimeRecord.TabIndex = 15;
            this.btnPastTimeRecord.Text = "Part time Staff \r\nWorking Record";
            this.btnPastTimeRecord.UseVisualStyleBackColor = true;
            this.btnPastTimeRecord.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnInventory);
            this.groupBox1.Controls.Add(this.btnShowcaseList);
            this.groupBox1.Controls.Add(this.btnRentShowcase);
            this.groupBox1.Controls.Add(this.btnReserve);
            this.groupBox1.Controls.Add(this.btnShowcaseSalesRecord);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 552);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Showcase Manangement";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(442, 410);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 98);
            this.button6.TabIndex = 43;
            this.button6.Text = "Showcase Rental Record ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(72, 420);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(224, 98);
            this.btnInventory.TabIndex = 42;
            this.btnInventory.Text = "Showcase Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btnViewSelf);
            this.groupBox3.Controls.Add(this.btnMonStatement);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(962, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(838, 866);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tenant";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(448, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 98);
            this.button4.TabIndex = 43;
            this.button4.Text = "Update Tenant";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(78, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 98);
            this.button3.TabIndex = 42;
            this.button3.Text = "New Tenant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // btnViewSelf
            // 
            this.btnViewSelf.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSelf.Location = new System.Drawing.Point(448, 54);
            this.btnViewSelf.Name = "btnViewSelf";
            this.btnViewSelf.Size = new System.Drawing.Size(224, 98);
            this.btnViewSelf.TabIndex = 41;
            this.btnViewSelf.Text = "View Self Item";
            this.btnViewSelf.UseVisualStyleBackColor = true;
            this.btnViewSelf.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(2360, 1158);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(224, 98);
            this.button28.TabIndex = 40;
            this.button28.Text = "Rent";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 964);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.btnTakingItem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.StaffManangement);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpItem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_menu";
            this.Text = "Main_menu";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.Shown += new System.EventHandler(this.Main_menu_Shown);
            this.grpItem.ResumeLayout(false);
            this.StaffManangement.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstoring;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnItemInfomation;
        private System.Windows.Forms.Button btnTakingItem;
        private System.Windows.Forms.Button btnSaling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosition;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowcaseList;
        private System.Windows.Forms.Button btnStaffList;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnShowcaseSalesRecord;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnRentShowcase;
        private System.Windows.Forms.Button btnMonStatement;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.GroupBox StaffManangement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button btnViewSelf;
        private System.Windows.Forms.Button btnPastTimeRecord;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnTList;
        private System.Windows.Forms.Button btnNewStaff;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}