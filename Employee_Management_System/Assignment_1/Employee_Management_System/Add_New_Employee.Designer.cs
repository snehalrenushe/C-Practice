namespace Employee_Management_System
{
    partial class frm_Add_New_Employee
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
            this.lbl_Post = new System.Windows.Forms.Label();
            this.lbl_Emp_ID = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.tb_Post = new System.Windows.Forms.TextBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_All_Employee = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(357, 9);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(627, 69);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Add New Employee";
            // 
            // lbl_Post
            // 
            this.lbl_Post.AutoSize = true;
            this.lbl_Post.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Post.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Post.Location = new System.Drawing.Point(192, 459);
            this.lbl_Post.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Post.Name = "lbl_Post";
            this.lbl_Post.Size = new System.Drawing.Size(109, 46);
            this.lbl_Post.TabIndex = 4;
            this.lbl_Post.Text = "Post";
            // 
            // lbl_Emp_ID
            // 
            this.lbl_Emp_ID.AutoSize = true;
            this.lbl_Emp_ID.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_ID.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Emp_ID.Location = new System.Drawing.Point(192, 167);
            this.lbl_Emp_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Emp_ID.Name = "lbl_Emp_ID";
            this.lbl_Emp_ID.Size = new System.Drawing.Size(173, 46);
            this.lbl_Emp_ID.TabIndex = 3;
            this.lbl_Emp_ID.Text = "Emp ID";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Purple;
            this.lbl_DOB.Location = new System.Drawing.Point(192, 366);
            this.lbl_DOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(293, 46);
            this.lbl_DOB.TabIndex = 6;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Name.Location = new System.Drawing.Point(192, 271);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(136, 46);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.tb_Name.Location = new System.Drawing.Point(770, 271);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(331, 39);
            this.tb_Name.TabIndex = 8;
            // 
            // tb_Emp_ID
            // 
            this.tb_Emp_ID.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.tb_Emp_ID.Location = new System.Drawing.Point(770, 176);
            this.tb_Emp_ID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Emp_ID.MaxLength = 10;
            this.tb_Emp_ID.Multiline = true;
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.Size = new System.Drawing.Size(331, 37);
            this.tb_Emp_ID.TabIndex = 7;
            // 
            // tb_Post
            // 
            this.tb_Post.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.tb_Post.Location = new System.Drawing.Point(770, 459);
            this.tb_Post.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Post.MaxLength = 30;
            this.tb_Post.Multiline = true;
            this.tb_Post.Name = "tb_Post";
            this.tb_Post.PasswordChar = '*';
            this.tb_Post.Size = new System.Drawing.Size(331, 39);
            this.tb_Post.TabIndex = 9;
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(770, 366);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(331, 26);
            this.dtp_Date_Of_Birth.TabIndex = 10;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Save.Location = new System.Drawing.Point(250, 572);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(156, 49);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_All_Employee
            // 
            this.btn_View_All_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_View_All_Employee.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Employee.ForeColor = System.Drawing.Color.Crimson;
            this.btn_View_All_Employee.Location = new System.Drawing.Point(531, 572);
            this.btn_View_All_Employee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_View_All_Employee.Name = "btn_View_All_Employee";
            this.btn_View_All_Employee.Size = new System.Drawing.Size(388, 49);
            this.btn_View_All_Employee.TabIndex = 12;
            this.btn_View_All_Employee.Text = "View All Employee";
            this.btn_View_All_Employee.UseVisualStyleBackColor = false;
            this.btn_View_All_Employee.Click += new System.EventHandler(this.btn_View_All_Employee_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Log_Out.Location = new System.Drawing.Point(1059, 29);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(161, 49);
            this.btn_Log_Out.TabIndex = 15;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1327, 697);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_View_All_Employee);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.tb_Post);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Emp_ID);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Post);
            this.Controls.Add(this.lbl_Emp_ID);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Post;
        private System.Windows.Forms.Label lbl_Emp_ID;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.TextBox tb_Post;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_All_Employee;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}