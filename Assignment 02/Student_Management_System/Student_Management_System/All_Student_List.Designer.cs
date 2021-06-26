namespace Student_Management_System
{
    partial class frm_All_Student_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.dgv_All_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Student_Management_SystemDataSet = new Student_Management_System.DB_Student_Management_SystemDataSet();
            this.btn_View_Student_By_Course = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter = new Student_Management_System.DB_Student_Management_SystemDataSetTableAdapters.Student_DetailsTableAdapter();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Student_Management_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Header.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Italic);
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(396, 21);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(600, 60);
            this.lbl_Header.TabIndex = 18;
            this.lbl_Header.Text = "View All Student List";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Navy;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(70, 620);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(296, 42);
            this.btn_Add_New_Student.TabIndex = 19;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = true;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_Details.ForeColor = System.Drawing.Color.Navy;
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(427, 620);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(369, 42);
            this.btn_Search_Student_Details.TabIndex = 20;
            this.btn_Search_Student_Details.Text = "Search Student Details";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = true;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // dgv_All_Student_List
            // 
            this.dgv_All_Student_List.AllowUserToAddRows = false;
            this.dgv_All_Student_List.AllowUserToDeleteRows = false;
            this.dgv_All_Student_List.AutoGenerateColumns = false;
            this.dgv_All_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_All_Student_List.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_All_Student_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_All_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_All_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_All_Student_List.DataSource = this.studentDetailsBindingSource;
            this.dgv_All_Student_List.Location = new System.Drawing.Point(82, 126);
            this.dgv_All_Student_List.Name = "dgv_All_Student_List";
            this.dgv_All_Student_List.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_All_Student_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_All_Student_List.RowHeadersWidth = 25;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_All_Student_List.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_All_Student_List.RowTemplate.Height = 28;
            this.dgv_All_Student_List.Size = new System.Drawing.Size(1187, 462);
            this.dgv_All_Student_List.TabIndex = 21;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.dB_Student_Management_SystemDataSet;
            // 
            // dB_Student_Management_SystemDataSet
            // 
            this.dB_Student_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_View_Student_By_Course
            // 
            this.btn_View_Student_By_Course.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Student_By_Course.ForeColor = System.Drawing.Color.Navy;
            this.btn_View_Student_By_Course.Location = new System.Drawing.Point(860, 620);
            this.btn_View_Student_By_Course.Name = "btn_View_Student_By_Course";
            this.btn_View_Student_By_Course.Size = new System.Drawing.Size(387, 42);
            this.btn_View_Student_By_Course.TabIndex = 22;
            this.btn_View_Student_By_Course.Text = "View Student By Course";
            this.btn_View_Student_By_Course.UseVisualStyleBackColor = true;
            this.btn_View_Student_By_Course.Click += new System.EventHandler(this.btn_View_Student_By_Course_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Navy;
            this.btn_Log_Out.Location = new System.Drawing.Point(1143, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(126, 37);
            this.btn_Log_Out.TabIndex = 23;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // frm_All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1359, 717);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_View_Student_By_Course);
            this.Controls.Add(this.dgv_All_Student_List);
            this.Controls.Add(this.btn_Search_Student_Details);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_All_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student List";
            this.Load += new System.EventHandler(this.All_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Student_Management_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Search_Student_Details;
        private System.Windows.Forms.DataGridView dgv_All_Student_List;
        private System.Windows.Forms.Button btn_View_Student_By_Course;
        private DB_Student_Management_SystemDataSet dB_Student_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private DB_Student_Management_SystemDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}