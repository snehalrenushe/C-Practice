namespace Product_Management_System
{
    partial class frm_Add_New_Product
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
            this.lbl_Add_New_Product = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Manufacturing_Date = new System.Windows.Forms.Label();
            this.lbl_Selling_Price = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.tb_Selling_Price = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.dtp_Manufacturing_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Logged_In_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Product
            // 
            this.lbl_Add_New_Product.AutoSize = true;
            this.lbl_Add_New_Product.Font = new System.Drawing.Font("Cooper Black", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Product.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_New_Product.Location = new System.Drawing.Point(593, 9);
            this.lbl_Add_New_Product.Name = "lbl_Add_New_Product";
            this.lbl_Add_New_Product.Size = new System.Drawing.Size(807, 96);
            this.lbl_Add_New_Product.TabIndex = 0;
            this.lbl_Add_New_Product.Text = "Add New Product";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Product_ID.Location = new System.Drawing.Point(397, 242);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(213, 41);
            this.lbl_Product_ID.TabIndex = 1;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // lbl_Manufacturing_Date
            // 
            this.lbl_Manufacturing_Date.AutoSize = true;
            this.lbl_Manufacturing_Date.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manufacturing_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Manufacturing_Date.Location = new System.Drawing.Point(397, 438);
            this.lbl_Manufacturing_Date.Name = "lbl_Manufacturing_Date";
            this.lbl_Manufacturing_Date.Size = new System.Drawing.Size(366, 41);
            this.lbl_Manufacturing_Date.TabIndex = 2;
            this.lbl_Manufacturing_Date.Text = "Manufacturing Date";
            // 
            // lbl_Selling_Price
            // 
            this.lbl_Selling_Price.AutoSize = true;
            this.lbl_Selling_Price.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selling_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Selling_Price.Location = new System.Drawing.Point(397, 645);
            this.lbl_Selling_Price.Name = "lbl_Selling_Price";
            this.lbl_Selling_Price.Size = new System.Drawing.Size(242, 41);
            this.lbl_Selling_Price.TabIndex = 3;
            this.lbl_Selling_Price.Text = "Selling Price";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(397, 541);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(279, 41);
            this.lbl_Purchase_Price.TabIndex = 4;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Product_Name.Location = new System.Drawing.Point(397, 339);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(262, 41);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(1105, 242);
            this.tb_Product_ID.MaxLength = 3;
            this.tb_Product_ID.Multiline = true;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(426, 44);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.TextChanged += new System.EventHandler(this.tb_Product_ID_TextChanged);
            this.tb_Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Selling_Price
            // 
            this.tb_Selling_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Selling_Price.Location = new System.Drawing.Point(1105, 645);
            this.tb_Selling_Price.Multiline = true;
            this.tb_Selling_Price.Name = "tb_Selling_Price";
            this.tb_Selling_Price.Size = new System.Drawing.Size(426, 44);
            this.tb_Selling_Price.TabIndex = 5;
            this.tb_Selling_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(1105, 339);
            this.tb_Product_Name.Multiline = true;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(426, 44);
            this.tb_Product_Name.TabIndex = 2;
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(1105, 541);
            this.tb_Purchase_Price.Multiline = true;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(426, 44);
            this.tb_Purchase_Price.TabIndex = 4;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_Manufacturing_Date
            // 
            this.dtp_Manufacturing_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Manufacturing_Date.Location = new System.Drawing.Point(1105, 438);
            this.dtp_Manufacturing_Date.Name = "dtp_Manufacturing_Date";
            this.dtp_Manufacturing_Date.Size = new System.Drawing.Size(426, 39);
            this.dtp_Manufacturing_Date.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Purple;
            this.btn_Save.Font = new System.Drawing.Font("Rockwell Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Save.Location = new System.Drawing.Point(805, 785);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(170, 68);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Logged_In_Username
            // 
            this.lbl_Logged_In_Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Logged_In_Username.AutoSize = true;
            this.lbl_Logged_In_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Logged_In_Username.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_Username.Location = new System.Drawing.Point(44, 18);
            this.lbl_Logged_In_Username.Name = "lbl_Logged_In_Username";
            this.lbl_Logged_In_Username.Size = new System.Drawing.Size(83, 30);
            this.lbl_Logged_In_Username.TabIndex = 9;
            this.lbl_Logged_In_Username.Text = "Admin";
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1738, 865);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Logged_In_Username);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Manufacturing_Date);
            this.Controls.Add(this.tb_Purchase_Price);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Selling_Price);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_Purchase_Price);
            this.Controls.Add(this.lbl_Selling_Price);
            this.Controls.Add(this.lbl_Manufacturing_Date);
            this.Controls.Add(this.lbl_Product_ID);
            this.Controls.Add(this.lbl_Add_New_Product);
            this.Name = "frm_Add_New_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Product;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Manufacturing_Date;
        private System.Windows.Forms.Label lbl_Selling_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.TextBox tb_Selling_Price;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.DateTimePicker dtp_Manufacturing_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Logged_In_Username;
    }
}