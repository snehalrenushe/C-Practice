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
            this.cb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "MSC",
            "MCA",
            "MBA",
            "M.B.B.S",
            "B.A.M.S."});
            this.cb_Course.Location = new System.Drawing.Point(502, 111);
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
            this.dgv_View_Student_Details_By_Course.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_View_Student_Details_By_Course.Location = new System.Drawing.Point(0, 264);
            this.dgv_View_Student_Details_By_Course.Name = "dgv_View_Student_Details_By_Course";
            this.dgv_View_Student_Details_By_Course.ReadOnly = true;
            this.dgv_View_Student_Details_By_Course.RowTemplate.Height = 28;
            this.dgv_View_Student_Details_By_Course.Size = new System.Drawing.Size(1359, 453);
            this.dgv_View_Student_Details_By_Course.TabIndex = 33;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Refresh.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.MediumOrchid;
            this.btn_Refresh.Location = new System.Drawing.Point(1106, 119);
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
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
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
        private System.Windows.Forms.Button btn_Refresh;
    }
}