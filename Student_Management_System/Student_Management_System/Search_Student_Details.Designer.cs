namespace Student_Management_System
{
    partial class frm_Search_Student_Details
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
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.btn_View_All_Student = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Course
            // 
            this.cb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Location = new System.Drawing.Point(734, 478);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(415, 45);
            this.cb_Course.TabIndex = 30;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Navy;
            this.btn_Reset.Location = new System.Drawing.Point(575, 609);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(178, 55);
            this.btn_Reset.TabIndex = 29;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(734, 320);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(415, 44);
            this.dtp_Date_Of_Birth.TabIndex = 20;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btn_Search.Location = new System.Drawing.Point(1043, 94);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(118, 41);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Course.Location = new System.Drawing.Point(172, 466);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(125, 41);
            this.lbl_Course.TabIndex = 28;
            this.lbl_Course.Text = "Course";
            // 
            // btn_View_All_Student
            // 
            this.btn_View_All_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_All_Student.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Student.ForeColor = System.Drawing.Color.Navy;
            this.btn_View_All_Student.Location = new System.Drawing.Point(864, 609);
            this.btn_View_All_Student.Name = "btn_View_All_Student";
            this.btn_View_All_Student.Size = new System.Drawing.Size(330, 55);
            this.btn_View_All_Student.TabIndex = 26;
            this.btn_View_All_Student.Text = "View All Student";
            this.btn_View_All_Student.UseVisualStyleBackColor = true;
            this.btn_View_All_Student.Click += new System.EventHandler(this.btn_View_All_Student_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log_Out.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Navy;
            this.btn_Log_Out.Location = new System.Drawing.Point(1156, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(126, 37);
            this.btn_Log_Out.TabIndex = 25;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(734, 393);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Multiline = true;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(415, 44);
            this.tb_Mobile_No.TabIndex = 21;
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(734, 161);
            this.tb_Roll_No.MaxLength = 12;
            this.tb_Roll_No.Multiline = true;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(415, 44);
            this.tb_Roll_No.TabIndex = 16;
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(172, 320);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(244, 41);
            this.lbl_Date_Of_Birth.TabIndex = 27;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Roll_No.Location = new System.Drawing.Point(172, 161);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(146, 41);
            this.lbl_Roll_No.TabIndex = 24;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(734, 239);
            this.tb_Name.MaxLength = 12;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(415, 44);
            this.tb_Name.TabIndex = 18;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(172, 393);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(187, 41);
            this.lbl_Mobile_No.TabIndex = 23;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Name.Location = new System.Drawing.Point(172, 242);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(111, 41);
            this.lbl_Name.TabIndex = 19;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Header.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Italic);
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(362, 23);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(632, 60);
            this.lbl_Header.TabIndex = 17;
            this.lbl_Header.Text = "Search Student Details";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Navy;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(139, 609);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(330, 55);
            this.btn_Add_New_Student.TabIndex = 31;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = true;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // frm_Search_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1359, 717);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.btn_View_All_Student);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Date_Of_Birth);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Search_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Button btn_View_All_Student;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Add_New_Student;
    }
}