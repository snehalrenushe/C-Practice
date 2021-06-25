namespace Book_Management_System
{
    partial class frm_Accept_Book_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accept_Book_Details));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Book_Price = new System.Windows.Forms.Label();
            this.lbl_Publish_Date = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lbl_Book_ID = new System.Windows.Forms.Label();
            this.tb_Book_Id = new System.Windows.Forms.TextBox();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.tb_Book_Price = new System.Windows.Forms.TextBox();
            this.dtp_Publish_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_View_Book_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Header.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Header.Location = new System.Drawing.Point(455, 33);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(421, 60);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Add New Book";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Log_Out.Location = new System.Drawing.Point(1133, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(134, 46);
            this.btn_Log_Out.TabIndex = 8;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Book_Price
            // 
            this.lbl_Book_Price.AutoSize = true;
            this.lbl_Book_Price.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Book_Price.Location = new System.Drawing.Point(193, 431);
            this.lbl_Book_Price.Name = "lbl_Book_Price";
            this.lbl_Book_Price.Size = new System.Drawing.Size(222, 44);
            this.lbl_Book_Price.TabIndex = 8;
            this.lbl_Book_Price.Text = "Book Price";
            // 
            // lbl_Publish_Date
            // 
            this.lbl_Publish_Date.AutoSize = true;
            this.lbl_Publish_Date.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Publish_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Publish_Date.Location = new System.Drawing.Point(193, 346);
            this.lbl_Publish_Date.Name = "lbl_Publish_Date";
            this.lbl_Publish_Date.Size = new System.Drawing.Size(257, 44);
            this.lbl_Publish_Date.TabIndex = 7;
            this.lbl_Publish_Date.Text = "Publish Date";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Book_Name.Location = new System.Drawing.Point(193, 248);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(228, 44);
            this.lbl_Book_Name.TabIndex = 10;
            this.lbl_Book_Name.Text = "Book Name";
            // 
            // lbl_Book_ID
            // 
            this.lbl_Book_ID.AutoSize = true;
            this.lbl_Book_ID.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Book_ID.Location = new System.Drawing.Point(193, 160);
            this.lbl_Book_ID.Name = "lbl_Book_ID";
            this.lbl_Book_ID.Size = new System.Drawing.Size(177, 44);
            this.lbl_Book_ID.TabIndex = 9;
            this.lbl_Book_ID.Text = "Book ID";
            // 
            // tb_Book_Id
            // 
            this.tb_Book_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Id.Location = new System.Drawing.Point(743, 162);
            this.tb_Book_Id.MaxLength = 5;
            this.tb_Book_Id.Multiline = true;
            this.tb_Book_Id.Name = "tb_Book_Id";
            this.tb_Book_Id.Size = new System.Drawing.Size(342, 42);
            this.tb_Book_Id.TabIndex = 1;
            this.tb_Book_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(743, 248);
            this.tb_Book_Name.MaxLength = 40;
            this.tb_Book_Name.Multiline = true;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(342, 42);
            this.tb_Book_Name.TabIndex = 2;
            // 
            // tb_Book_Price
            // 
            this.tb_Book_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Price.Location = new System.Drawing.Point(743, 431);
            this.tb_Book_Price.MaxLength = 6;
            this.tb_Book_Price.Multiline = true;
            this.tb_Book_Price.Name = "tb_Book_Price";
            this.tb_Book_Price.Size = new System.Drawing.Size(342, 40);
            this.tb_Book_Price.TabIndex = 4;
            this.tb_Book_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Float_Numeric);
            // 
            // dtp_Publish_Date
            // 
            this.dtp_Publish_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_Publish_Date.Location = new System.Drawing.Point(743, 346);
            this.dtp_Publish_Date.Name = "dtp_Publish_Date";
            this.dtp_Publish_Date.Size = new System.Drawing.Size(342, 35);
            this.dtp_Publish_Date.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Save.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Location = new System.Drawing.Point(271, 553);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(179, 53);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Close.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Close.Location = new System.Drawing.Point(906, 553);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(179, 53);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_View_Book_Details
            // 
            this.btn_View_Book_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_View_Book_Details.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Book_Details.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_View_Book_Details.Location = new System.Drawing.Point(527, 553);
            this.btn_View_Book_Details.Name = "btn_View_Book_Details";
            this.btn_View_Book_Details.Size = new System.Drawing.Size(292, 53);
            this.btn_View_Book_Details.TabIndex = 6;
            this.btn_View_Book_Details.Text = "View_Book_Details";
            this.btn_View_Book_Details.UseVisualStyleBackColor = false;
            this.btn_View_Book_Details.Click += new System.EventHandler(this.btn_View_Book_Details_Click);
            // 
            // frm_Accept_Book_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1279, 674);
            this.Controls.Add(this.btn_View_Book_Details);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Publish_Date);
            this.Controls.Add(this.tb_Book_Price);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.tb_Book_Id);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_Book_ID);
            this.Controls.Add(this.lbl_Book_Price);
            this.Controls.Add(this.lbl_Publish_Date);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Accept_Book_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accept Book Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Book_Price;
        private System.Windows.Forms.Label lbl_Publish_Date;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lbl_Book_ID;
        private System.Windows.Forms.TextBox tb_Book_Id;
        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.TextBox tb_Book_Price;
        private System.Windows.Forms.DateTimePicker dtp_Publish_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_View_Book_Details;
    }
}