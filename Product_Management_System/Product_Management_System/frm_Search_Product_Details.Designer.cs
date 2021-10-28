namespace Product_Management_System
{
    partial class frm_Search_Product_Details
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_Manufacturing_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Selling_Price = new System.Windows.Forms.TextBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Selling_Price = new System.Windows.Forms.Label();
            this.lbl_Manufacturing_Date = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Search_Product_Details = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Purple;
            this.btn_Search.Font = new System.Drawing.Font("Rockwell Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Search.Location = new System.Drawing.Point(1317, 163);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(170, 68);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_Manufacturing_Date
            // 
            this.dtp_Manufacturing_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Manufacturing_Date.Location = new System.Drawing.Point(1117, 443);
            this.dtp_Manufacturing_Date.Name = "dtp_Manufacturing_Date";
            this.dtp_Manufacturing_Date.Size = new System.Drawing.Size(426, 39);
            this.dtp_Manufacturing_Date.TabIndex = 15;
            
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(1117, 546);
            this.tb_Purchase_Price.Multiline = true;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(426, 44);
            this.tb_Purchase_Price.TabIndex = 17;
         
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(1117, 344);
            this.tb_Product_Name.Multiline = true;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(426, 44);
            this.tb_Product_Name.TabIndex = 13;
           
            // 
            // tb_Selling_Price
            // 
            this.tb_Selling_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Selling_Price.Location = new System.Drawing.Point(1117, 650);
            this.tb_Selling_Price.Multiline = true;
            this.tb_Selling_Price.Name = "tb_Selling_Price";
            this.tb_Selling_Price.Size = new System.Drawing.Size(426, 44);
            this.tb_Selling_Price.TabIndex = 18;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(1117, 247);
            this.tb_Product_ID.MaxLength = 3;
            this.tb_Product_ID.Multiline = true;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(426, 44);
            this.tb_Product_ID.TabIndex = 10;
            
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Product_Name.Location = new System.Drawing.Point(409, 344);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(262, 41);
            this.lbl_Product_Name.TabIndex = 19;
            this.lbl_Product_Name.Text = "Product Name";
            
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(409, 546);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(279, 41);
            this.lbl_Purchase_Price.TabIndex = 16;
            this.lbl_Purchase_Price.Text = "Purchase Price";
      
            // 
            // lbl_Selling_Price
            // 
            this.lbl_Selling_Price.AutoSize = true;
            this.lbl_Selling_Price.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selling_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Selling_Price.Location = new System.Drawing.Point(409, 650);
            this.lbl_Selling_Price.Name = "lbl_Selling_Price";
            this.lbl_Selling_Price.Size = new System.Drawing.Size(242, 41);
            this.lbl_Selling_Price.TabIndex = 14;
            this.lbl_Selling_Price.Text = "Selling Price";
     
            // 
            // lbl_Manufacturing_Date
            // 
            this.lbl_Manufacturing_Date.AutoSize = true;
            this.lbl_Manufacturing_Date.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manufacturing_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Manufacturing_Date.Location = new System.Drawing.Point(409, 443);
            this.lbl_Manufacturing_Date.Name = "lbl_Manufacturing_Date";
            this.lbl_Manufacturing_Date.Size = new System.Drawing.Size(366, 41);
            this.lbl_Manufacturing_Date.TabIndex = 12;
            this.lbl_Manufacturing_Date.Text = "Manufacturing Date";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Product_ID.Location = new System.Drawing.Point(409, 247);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(213, 41);
            this.lbl_Product_ID.TabIndex = 11;
            this.lbl_Product_ID.Text = "Product ID";
            
            // 
            // lbl_Search_Product_Details
            // 
            this.lbl_Search_Product_Details.AutoSize = true;
            this.lbl_Search_Product_Details.Font = new System.Drawing.Font("Cooper Black", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Product_Details.ForeColor = System.Drawing.Color.Red;
            this.lbl_Search_Product_Details.Location = new System.Drawing.Point(477, 31);
            this.lbl_Search_Product_Details.Name = "lbl_Search_Product_Details";
            this.lbl_Search_Product_Details.Size = new System.Drawing.Size(1023, 96);
            this.lbl_Search_Product_Details.TabIndex = 9;
            this.lbl_Search_Product_Details.Text = "Search Product Details";
           
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Purple;
            this.btn_Refresh.Font = new System.Drawing.Font("Rockwell Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Location = new System.Drawing.Point(861, 788);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(170, 68);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Search_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1677, 895);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
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
            this.Controls.Add(this.lbl_Search_Product_Details);
            this.Name = "frm_Search_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Product Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_Manufacturing_Date;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Selling_Price;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Selling_Price;
        private System.Windows.Forms.Label lbl_Manufacturing_Date;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Search_Product_Details;
        private System.Windows.Forms.Button btn_Refresh;
    }
}