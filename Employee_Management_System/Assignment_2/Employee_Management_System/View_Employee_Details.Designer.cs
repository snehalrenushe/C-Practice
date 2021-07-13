namespace Employee_Management_System
{
    partial class frm_View_Employee_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Employee_Management_SystemDataSet = new Employee_Management_System.DB_Employee_Management_SystemDataSet();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.employee_DetailsTableAdapter = new Employee_Management_System.DB_Employee_Management_SystemDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.btn_Search_Employee_Details_By_Department = new System.Windows.Forms.Button();
            this.btn_Search_Employee_Details = new System.Windows.Forms.Button();
            this.dB_Employee_Management_SystemDataSet2 = new Employee_Management_System.DB_Employee_Management_SystemDataSet2();
            this.employeeDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter1 = new Employee_Management_System.DB_Employee_Management_SystemDataSet2TableAdapters.Employee_DetailsTableAdapter();
            this.dB_Employee_Management_SystemDataSet3 = new Employee_Management_System.DB_Employee_Management_SystemDataSet3();
            this.employeeDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter2 = new Employee_Management_System.DB_Employee_Management_SystemDataSet3TableAdapters.Employee_DetailsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_View_All_Details = new System.Windows.Forms.DataGridView();
            this.employeeDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Employee_Management_SystemDataSet4 = new Employee_Management_System.DB_Employee_Management_SystemDataSet4();
            this.employee_DetailsTableAdapter3 = new Employee_Management_System.DB_Employee_Management_SystemDataSet4TableAdapters.Employee_DetailsTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Management_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Management_SystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Management_SystemDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(338, 28);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(659, 69);
            this.lbl_Header.TabIndex = 7;
            this.lbl_Header.Text = "View Employee Details";
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(940, 601);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(291, 43);
            this.btn_Add_New_Employee.TabIndex = 12;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.dB_Employee_Management_SystemDataSet;
            // 
            // dB_Employee_Management_SystemDataSet
            // 
            this.dB_Employee_Management_SystemDataSet.DataSetName = "DB_Employee_Management_SystemDataSet";
            this.dB_Employee_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Log_Out.Location = new System.Drawing.Point(1078, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(141, 38);
            this.btn_Log_Out.TabIndex = 21;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Search_Employee_Details_By_Department
            // 
            this.btn_Search_Employee_Details_By_Department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search_Employee_Details_By_Department.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Employee_Details_By_Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Search_Employee_Details_By_Department.Location = new System.Drawing.Point(420, 604);
            this.btn_Search_Employee_Details_By_Department.Name = "btn_Search_Employee_Details_By_Department";
            this.btn_Search_Employee_Details_By_Department.Size = new System.Drawing.Size(469, 37);
            this.btn_Search_Employee_Details_By_Department.TabIndex = 36;
            this.btn_Search_Employee_Details_By_Department.Text = "Search Employee Details By Department";
            this.btn_Search_Employee_Details_By_Department.UseVisualStyleBackColor = false;
            this.btn_Search_Employee_Details_By_Department.Click += new System.EventHandler(this.btn_Search_Employee_Details_By_Department_Click);
            // 
            // btn_Search_Employee_Details
            // 
            this.btn_Search_Employee_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search_Employee_Details.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Employee_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Search_Employee_Details.Location = new System.Drawing.Point(67, 604);
            this.btn_Search_Employee_Details.Name = "btn_Search_Employee_Details";
            this.btn_Search_Employee_Details.Size = new System.Drawing.Size(305, 37);
            this.btn_Search_Employee_Details.TabIndex = 37;
            this.btn_Search_Employee_Details.Text = "Search Employee Details";
            this.btn_Search_Employee_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Employee_Details.Click += new System.EventHandler(this.btn_Search_Employee_Details_Click);
            // 
            // dB_Employee_Management_SystemDataSet2
            // 
            this.dB_Employee_Management_SystemDataSet2.DataSetName = "DB_Employee_Management_SystemDataSet2";
            this.dB_Employee_Management_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource1
            // 
            this.employeeDetailsBindingSource1.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource1.DataSource = this.dB_Employee_Management_SystemDataSet2;
            // 
            // employee_DetailsTableAdapter1
            // 
            this.employee_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // dB_Employee_Management_SystemDataSet3
            // 
            this.dB_Employee_Management_SystemDataSet3.DataSetName = "DB_Employee_Management_SystemDataSet3";
            this.dB_Employee_Management_SystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource2
            // 
            this.employeeDetailsBindingSource2.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource2.DataSource = this.dB_Employee_Management_SystemDataSet3;
            // 
            // employee_DetailsTableAdapter2
            // 
            this.employee_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.employeeDetailsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(43, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 420);
            this.dataGridView1.TabIndex = 38;
            // 
            // dgv_View_All_Details
            // 
            this.dgv_View_All_Details.AllowUserToAddRows = false;
            this.dgv_View_All_Details.AllowUserToDeleteRows = false;
            this.dgv_View_All_Details.AutoGenerateColumns = false;
            this.dgv_View_All_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Details.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_All_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_View_All_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.dOBDataGridViewTextBoxColumn1,
            this.salaryDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn1});
            this.dgv_View_All_Details.DataSource = this.employeeDetailsBindingSource3;
            this.dgv_View_All_Details.Location = new System.Drawing.Point(44, 133);
            this.dgv_View_All_Details.Name = "dgv_View_All_Details";
            this.dgv_View_All_Details.ReadOnly = true;
            this.dgv_View_All_Details.RowTemplate.Height = 28;
            this.dgv_View_All_Details.Size = new System.Drawing.Size(1187, 450);
            this.dgv_View_All_Details.TabIndex = 38;
            // 
            // employeeDetailsBindingSource3
            // 
            this.employeeDetailsBindingSource3.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource3.DataSource = this.dB_Employee_Management_SystemDataSet4;
            // 
            // dB_Employee_Management_SystemDataSet4
            // 
            this.dB_Employee_Management_SystemDataSet4.DataSetName = "DB_Employee_Management_SystemDataSet4";
            this.dB_Employee_Management_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_DetailsTableAdapter3
            // 
            this.employee_DetailsTableAdapter3.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn1
            // 
            this.dOBDataGridViewTextBoxColumn1.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn1.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn1.Name = "dOBDataGridViewTextBoxColumn1";
            this.dOBDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn1
            // 
            this.salaryDataGridViewTextBoxColumn1.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn1.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn1.Name = "salaryDataGridViewTextBoxColumn1";
            this.salaryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn1
            // 
            this.departmentDataGridViewTextBoxColumn1.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn1.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn1.Name = "departmentDataGridViewTextBoxColumn1";
            this.departmentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frm_View_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1402, 713);
            this.Controls.Add(this.dgv_View_All_Details);
            this.Controls.Add(this.btn_Search_Employee_Details);
            this.Controls.Add(this.btn_Search_Employee_Details_By_Department);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_View_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee Details";
            this.Load += new System.EventHandler(this.frm_View_Employee_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Management_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Management_SystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Management_SystemDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Button btn_Log_Out;
        private DB_Employee_Management_SystemDataSet dB_Employee_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private DB_Employee_Management_SystemDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_Search_Employee_Details_By_Department;
        private System.Windows.Forms.Button btn_Search_Employee_Details;
        private DB_Employee_Management_SystemDataSet2 dB_Employee_Management_SystemDataSet2;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource1;
        private DB_Employee_Management_SystemDataSet2TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter1;
        private DB_Employee_Management_SystemDataSet3 dB_Employee_Management_SystemDataSet3;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource2;
        private DB_Employee_Management_SystemDataSet3TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgv_View_All_Details;
        private DB_Employee_Management_SystemDataSet4 dB_Employee_Management_SystemDataSet4;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource3;
        private DB_Employee_Management_SystemDataSet4TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
    }
}