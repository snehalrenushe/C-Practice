namespace Staff_Management_System
{
    partial class frm_Add_Department
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Department_Name = new System.Windows.Forms.TextBox();
            this.lbl_Department_Name = new System.Windows.Forms.Label();
            this.tb_Department_ID = new System.Windows.Forms.TextBox();
            this.lbl_Department_ID = new System.Windows.Forms.Label();
            this.lbl_Add_Department = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(281, 519);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(202, 57);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // tb_Department_Name
            // 
            this.tb_Department_Name.Font = new System.Drawing.Font("Rockwell", 18F);
            this.tb_Department_Name.Location = new System.Drawing.Point(730, 385);
            this.tb_Department_Name.MaxLength = 15;
            this.tb_Department_Name.Multiline = true;
            this.tb_Department_Name.Name = "tb_Department_Name";
            this.tb_Department_Name.Size = new System.Drawing.Size(393, 49);
            this.tb_Department_Name.TabIndex = 14;
            // 
            // lbl_Department_Name
            // 
            this.lbl_Department_Name.AutoSize = true;
            this.lbl_Department_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Department_Name.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Department_Name.Location = new System.Drawing.Point(175, 385);
            this.lbl_Department_Name.Name = "lbl_Department_Name";
            this.lbl_Department_Name.Size = new System.Drawing.Size(391, 49);
            this.lbl_Department_Name.TabIndex = 13;
            this.lbl_Department_Name.Text = "Department Name";
            // 
            // tb_Department_ID
            // 
            this.tb_Department_ID.Font = new System.Drawing.Font("Rockwell", 18F);
            this.tb_Department_ID.Location = new System.Drawing.Point(730, 216);
            this.tb_Department_ID.MaxLength = 10;
            this.tb_Department_ID.Multiline = true;
            this.tb_Department_ID.Name = "tb_Department_ID";
            this.tb_Department_ID.Size = new System.Drawing.Size(393, 49);
            this.tb_Department_ID.TabIndex = 12;
            // 
            // lbl_Department_ID
            // 
            this.lbl_Department_ID.AutoSize = true;
            this.lbl_Department_ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Department_ID.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Department_ID.Location = new System.Drawing.Point(175, 216);
            this.lbl_Department_ID.Name = "lbl_Department_ID";
            this.lbl_Department_ID.Size = new System.Drawing.Size(319, 49);
            this.lbl_Department_ID.TabIndex = 11;
            this.lbl_Department_ID.Text = "Department ID";
            // 
            // lbl_Add_Department
            // 
            this.lbl_Add_Department.AutoSize = true;
            this.lbl_Add_Department.BackColor = System.Drawing.Color.OldLace;
            this.lbl_Add_Department.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Department.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Add_Department.Location = new System.Drawing.Point(314, 24);
            this.lbl_Add_Department.Name = "lbl_Add_Department";
            this.lbl_Add_Department.Size = new System.Drawing.Size(700, 98);
            this.lbl_Add_Department.TabIndex = 9;
            this.lbl_Add_Department.Text = "Add Department";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Close.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Red;
            this.btn_Close.Location = new System.Drawing.Point(812, 519);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(202, 57);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // frm_Add_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 694);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Department_Name);
            this.Controls.Add(this.lbl_Department_Name);
            this.Controls.Add(this.tb_Department_ID);
            this.Controls.Add(this.lbl_Department_ID);
            this.Controls.Add(this.lbl_Add_Department);
            this.Name = "frm_Add_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Department";
            this.Load += new System.EventHandler(this.frm_Add_Department_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Department_Name;
        private System.Windows.Forms.Label lbl_Department_Name;
        private System.Windows.Forms.TextBox tb_Department_ID;
        private System.Windows.Forms.Label lbl_Department_ID;
        private System.Windows.Forms.Label lbl_Add_Department;
        private System.Windows.Forms.Button btn_Close;
    }
}