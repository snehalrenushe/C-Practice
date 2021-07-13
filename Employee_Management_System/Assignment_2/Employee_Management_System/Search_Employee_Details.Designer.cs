﻿namespace Employee_Management_System
{
    partial class frm_Search_Employee_Details
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.btn_View_All_Details = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Search_Employee_Details_By_Department = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(344, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(721, 69);
            this.lbl_Header.TabIndex = 7;
            this.lbl_Header.Text = "Search Employee Details";
            // 
            // cb_Department
            // 
            this.cb_Department.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Items.AddRange(new object[] {
            "HR",
            "Manager",
            "Accounts and Finance",
            "Sales and marketing",
            "Research and development",
            "Learning and development",
            "Product development",
            "Admin department",
            "Security and transport."});
            this.cb_Department.Location = new System.Drawing.Point(807, 510);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(344, 42);
            this.cb_Department.TabIndex = 29;
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(807, 353);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(344, 42);
            this.dtp_Date_Of_Birth.TabIndex = 28;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Department.Location = new System.Drawing.Point(192, 500);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(260, 51);
            this.lbl_Department.TabIndex = 27;
            this.lbl_Department.Text = "Department";
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Modern No. 20", 17F);
            this.tb_Salary.Location = new System.Drawing.Point(807, 428);
            this.tb_Salary.MaxLength = 20;
            this.tb_Salary.Multiline = true;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(344, 40);
            this.tb_Salary.TabIndex = 26;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Salary.Location = new System.Drawing.Point(192, 417);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(153, 51);
            this.lbl_Salary.TabIndex = 25;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(192, 333);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(309, 51);
            this.lbl_Date_Of_Birth.TabIndex = 21;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 17F);
            this.tb_Name.Location = new System.Drawing.Point(807, 254);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(344, 40);
            this.tb_Name.TabIndex = 24;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 17F);
            this.tb_ID.Location = new System.Drawing.Point(807, 172);
            this.tb_ID.MaxLength = 40000;
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(344, 40);
            this.tb_ID.TabIndex = 23;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Name.Location = new System.Drawing.Point(192, 254);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(138, 51);
            this.lbl_Name.TabIndex = 20;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_ID.Location = new System.Drawing.Point(192, 161);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(79, 51);
            this.lbl_ID.TabIndex = 22;
            this.lbl_ID.Text = "ID";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Log_Out.Location = new System.Drawing.Point(1109, 20);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(148, 36);
            this.btn_Log_Out.TabIndex = 30;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(103, 601);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(271, 47);
            this.btn_Add_New_Employee.TabIndex = 31;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // btn_View_All_Details
            // 
            this.btn_View_All_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_View_All_Details.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_View_All_Details.Location = new System.Drawing.Point(916, 599);
            this.btn_View_All_Details.Name = "btn_View_All_Details";
            this.btn_View_All_Details.Size = new System.Drawing.Size(235, 45);
            this.btn_View_All_Details.TabIndex = 32;
            this.btn_View_All_Details.Text = "View All Details";
            this.btn_View_All_Details.UseVisualStyleBackColor = false;
            this.btn_View_All_Details.Click += new System.EventHandler(this.btn_View_All_Details_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Search.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Search.Location = new System.Drawing.Point(933, 92);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(132, 39);
            this.btn_Search.TabIndex = 33;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Reset.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Reset.Location = new System.Drawing.Point(1142, 128);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(90, 38);
            this.btn_Reset.TabIndex = 34;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Search_Employee_Details_By_Department
            // 
            this.btn_Search_Employee_Details_By_Department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search_Employee_Details_By_Department.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Employee_Details_By_Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Search_Employee_Details_By_Department.Location = new System.Drawing.Point(415, 599);
            this.btn_Search_Employee_Details_By_Department.Name = "btn_Search_Employee_Details_By_Department";
            this.btn_Search_Employee_Details_By_Department.Size = new System.Drawing.Size(464, 51);
            this.btn_Search_Employee_Details_By_Department.TabIndex = 35;
            this.btn_Search_Employee_Details_By_Department.Text = "Search Employee Details By Department";
            this.btn_Search_Employee_Details_By_Department.UseVisualStyleBackColor = false;
            this.btn_Search_Employee_Details_By_Department.Click += new System.EventHandler(this.btn_Search_Employee_Details_By_Department_Click);
            // 
            // frm_Search_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1343, 713);
            this.Controls.Add(this.btn_Search_Employee_Details_By_Department);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_View_All_Details);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.tb_Salary);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Date_Of_Birth);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Search_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Employee Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Button btn_View_All_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Search_Employee_Details_By_Department;
    }
}