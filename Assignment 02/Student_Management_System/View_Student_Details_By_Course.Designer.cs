namespace Student_Management_System
{
    partial class frm_View_Student_Details_By_Course
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
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.dgv_View_Student_Details_By_Course = new System.Windows.Forms.DataGridView();
            this.btn_View_All_Student_List = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_Details_By_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Header.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Italic);
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(404, 22);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(600, 60);
            this.lbl_Header.TabIndex = 19;
            this.lbl_Header.Text = "View All Student List";
            // 
            // cb_Course
            // 
            this.cb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Location = new System.Drawing.Point(480, 111);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(415, 45);
            this.cb_Course.TabIndex = 32;
            this.cb_Course.SelectedIndexChanged += new System.EventHandler(this.cb_Course_SelectedIndexChanged);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Course.Location = new System.Drawing.Point(328, 115);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(125, 41);
            this.lbl_Course.TabIndex = 31;
            this.lbl_Course.Text = "Course";
            // 
            // dgv_View_Student_Details_By_Course
            // 
            this.dgv_View_Student_Details_By_Course.AllowUserToAddRows = false;
            this.dgv_View_Student_Details_By_Course.AllowUserToDeleteRows = false;
            this.dgv_View_Student_Details_By_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student_Details_By_Course.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgv_View_Student_Details_By_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_Details_By_Course.Location = new System.Drawing.Point(97, 194);
            this.dgv_View_Student_Details_By_Course.Name = "dgv_View_Student_Details_By_Course";
            this.dgv_View_Student_Details_By_Course.ReadOnly = true;
            this.dgv_View_Student_Details_By_Course.RowTemplate.Height = 28;
            this.dgv_View_Student_Details_By_Course.Size = new System.Drawing.Size(1154, 401);
            this.dgv_View_Student_Details_By_Course.TabIndex = 33;
            // 
            // btn_View_All_Student_List
            // 
            this.btn_View_All_Student_List.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Student_List.ForeColor = System.Drawing.Color.Navy;
            this.btn_View_All_Student_List.Location = new System.Drawing.Point(879, 628);
            this.btn_View_All_Student_List.Name = "btn_View_All_Student_List";
            this.btn_View_All_Student_List.Size = new System.Drawing.Size(387, 42);
            this.btn_View_All_Student_List.TabIndex = 34;
            this.btn_View_All_Student_List.Text = "View All Student List";
            this.btn_View_All_Student_List.UseVisualStyleBackColor = true;
            this.btn_View_All_Student_List.Click += new System.EventHandler(this.btn_View_Student_By_Course_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Navy;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(134, 628);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(296, 42);
            this.btn_Add_New_Student.TabIndex = 35;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = true;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_Details.ForeColor = System.Drawing.Color.Navy;
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(469, 628);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(369, 42);
            this.btn_Search_Student_Details.TabIndex = 36;
            this.btn_Search_Student_Details.Text = "Search Student Details";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = true;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Navy;
            this.btn_Log_Out.Location = new System.Drawing.Point(1115, 22);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(126, 37);
            this.btn_Log_Out.TabIndex = 37;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Refresh.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.MediumOrchid;
            this.btn_Refresh.Location = new System.Drawing.Point(1115, 151);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(115, 37);
            this.btn_Refresh.TabIndex = 38;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_View_Student_Details_By_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1359, 717);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Search_Student_Details);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_View_All_Student_List);
            this.Controls.Add(this.dgv_View_Student_Details_By_Course);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_View_Student_Details_By_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student Details By Course";
            this.Load += new System.EventHandler(this.frm_View_Student_Details_By_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_Details_By_Course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.DataGridView dgv_View_Student_Details_By_Course;
        private System.Windows.Forms.Button btn_View_All_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Search_Student_Details;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Refresh;
    }
}