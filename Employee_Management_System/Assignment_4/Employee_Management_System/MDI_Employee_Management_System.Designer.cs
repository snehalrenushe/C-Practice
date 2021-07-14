namespace Employee_Management_System
{
    partial class MDI_Employee_Management_System
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeDetailsByDeptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Logged_In_Username = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1305, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEmployeeToolStripMenuItem,
            this.searchEmployeeDetailsToolStripMenuItem,
            this.updateEmployeeDetailsToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // searchEmployeeDetailsToolStripMenuItem
            // 
            this.searchEmployeeDetailsToolStripMenuItem.Name = "searchEmployeeDetailsToolStripMenuItem";
            this.searchEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.searchEmployeeDetailsToolStripMenuItem.Text = "Search Employee Details";
            this.searchEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchEmployeeDetailsToolStripMenuItem_Click);
            // 
            // updateEmployeeDetailsToolStripMenuItem
            // 
            this.updateEmployeeDetailsToolStripMenuItem.Name = "updateEmployeeDetailsToolStripMenuItem";
            this.updateEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.updateEmployeeDetailsToolStripMenuItem.Text = "Update Employee Details";
            this.updateEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeDetailsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeeDetailsByDeptToolStripMenuItem,
            this.viewEmployeeDetailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewEmployeeDetailsByDeptToolStripMenuItem
            // 
            this.viewEmployeeDetailsByDeptToolStripMenuItem.Name = "viewEmployeeDetailsByDeptToolStripMenuItem";
            this.viewEmployeeDetailsByDeptToolStripMenuItem.Size = new System.Drawing.Size(346, 30);
            this.viewEmployeeDetailsByDeptToolStripMenuItem.Text = "Search Employee Details by Dept";
            this.viewEmployeeDetailsByDeptToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeDetailsByDeptToolStripMenuItem_Click);
            // 
            // viewEmployeeDetailsToolStripMenuItem
            // 
            this.viewEmployeeDetailsToolStripMenuItem.Name = "viewEmployeeDetailsToolStripMenuItem";
            this.viewEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(346, 30);
            this.viewEmployeeDetailsToolStripMenuItem.Text = "View Employee Details";
            this.viewEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeDetailsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Visible = false;
            // 
            // lbl_Logged_In_Username
            // 
            this.lbl_Logged_In_Username.AutoSize = true;
            this.lbl_Logged_In_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_Logged_In_Username.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_Username.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Logged_In_Username.Location = new System.Drawing.Point(889, 9);
            this.lbl_Logged_In_Username.Name = "lbl_Logged_In_Username";
            this.lbl_Logged_In_Username.Size = new System.Drawing.Size(194, 21);
            this.lbl_Logged_In_Username.TabIndex = 24;
            this.lbl_Logged_In_Username.Text = "Logged In User Name";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Log_Out.Location = new System.Drawing.Point(1112, 1);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(148, 36);
            this.btn_Log_Out.TabIndex = 31;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // MDI_Employee_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 697);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_Logged_In_Username);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDI_Employee_Management_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.Load += new System.EventHandler(this.MDI_Employee_Management_System_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeDetailsByDeptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Logged_In_Username;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}



