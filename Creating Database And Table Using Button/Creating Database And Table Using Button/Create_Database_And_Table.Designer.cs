namespace Creating_Database_And_Table_Using_Button
{
    partial class Create_Database_And_Table
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
            this.lbl_Database = new System.Windows.Forms.Label();
            this.tb_Database = new System.Windows.Forms.TextBox();
            this.tb_Table_Name = new System.Windows.Forms.TextBox();
            this.lbl_Table_Name = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Database.Location = new System.Drawing.Point(130, 109);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(154, 37);
            this.lbl_Database.TabIndex = 0;
            this.lbl_Database.Text = "Database";
            // 
            // tb_Database
            // 
            this.tb_Database.Location = new System.Drawing.Point(467, 109);
            this.tb_Database.Multiline = true;
            this.tb_Database.Name = "tb_Database";
            this.tb_Database.Size = new System.Drawing.Size(222, 37);
            this.tb_Database.TabIndex = 1;
            // 
            // tb_Table_Name
            // 
            this.tb_Table_Name.Location = new System.Drawing.Point(467, 252);
            this.tb_Table_Name.Multiline = true;
            this.tb_Table_Name.Name = "tb_Table_Name";
            this.tb_Table_Name.Size = new System.Drawing.Size(222, 37);
            this.tb_Table_Name.TabIndex = 3;
            // 
            // lbl_Table_Name
            // 
            this.lbl_Table_Name.AutoSize = true;
            this.lbl_Table_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Table_Name.Location = new System.Drawing.Point(130, 252);
            this.lbl_Table_Name.Name = "lbl_Table_Name";
            this.lbl_Table_Name.Size = new System.Drawing.Size(192, 37);
            this.lbl_Table_Name.TabIndex = 2;
            this.lbl_Table_Name.Text = "Table Name";
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(335, 387);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(131, 49);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // Create_Database_And_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 551);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tb_Table_Name);
            this.Controls.Add(this.lbl_Table_Name);
            this.Controls.Add(this.tb_Database);
            this.Controls.Add(this.lbl_Database);
            this.Name = "Create_Database_And_Table";
            this.Text = "Database And Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.TextBox tb_Database;
        private System.Windows.Forms.TextBox tb_Table_Name;
        private System.Windows.Forms.Label lbl_Table_Name;
        private System.Windows.Forms.Button btn_Create;
    }
}

