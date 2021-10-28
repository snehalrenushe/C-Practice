namespace Product_Management_System
{
    partial class frm_View_Product_Dynamically
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_View_Product_Details = new System.Windows.Forms.Label();
            this.dgv_View_Product_Dynamically = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dtp_Manufacturing_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Manufacturing_Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Product_Dynamically)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Product_Details
            // 
            this.lbl_View_Product_Details.AutoSize = true;
            this.lbl_View_Product_Details.Font = new System.Drawing.Font("Cooper Black", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Product_Details.ForeColor = System.Drawing.Color.Red;
            this.lbl_View_Product_Details.Location = new System.Drawing.Point(494, 9);
            this.lbl_View_Product_Details.Name = "lbl_View_Product_Details";
            this.lbl_View_Product_Details.Size = new System.Drawing.Size(955, 96);
            this.lbl_View_Product_Details.TabIndex = 2;
            this.lbl_View_Product_Details.Text = "View Product Details";
            // 
            // dgv_View_Product_Dynamically
            // 
            this.dgv_View_Product_Dynamically.AllowUserToAddRows = false;
            this.dgv_View_Product_Dynamically.AllowUserToDeleteRows = false;
            this.dgv_View_Product_Dynamically.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Product_Dynamically.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Product_Dynamically.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Product_Dynamically.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Product_Dynamically.Location = new System.Drawing.Point(61, 287);
            this.dgv_View_Product_Dynamically.Name = "dgv_View_Product_Dynamically";
            this.dgv_View_Product_Dynamically.ReadOnly = true;
            this.dgv_View_Product_Dynamically.RowTemplate.Height = 28;
            this.dgv_View_Product_Dynamically.Size = new System.Drawing.Size(1786, 428);
            this.dgv_View_Product_Dynamically.TabIndex = 3;
            this.dgv_View_Product_Dynamically.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Purple;
            this.btn_Refresh.Font = new System.Drawing.Font("Rockwell Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Location = new System.Drawing.Point(840, 793);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(170, 68);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dtp_Manufacturing_Date
            // 
            this.dtp_Manufacturing_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Manufacturing_Date.Location = new System.Drawing.Point(1023, 170);
            this.dtp_Manufacturing_Date.Name = "dtp_Manufacturing_Date";
            this.dtp_Manufacturing_Date.Size = new System.Drawing.Size(426, 39);
            this.dtp_Manufacturing_Date.TabIndex = 12;
            this.dtp_Manufacturing_Date.ValueChanged += new System.EventHandler(this.dtp_Manufacturing_Date_ValueChanged);
            // 
            // lbl_Manufacturing_Date
            // 
            this.lbl_Manufacturing_Date.AutoSize = true;
            this.lbl_Manufacturing_Date.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manufacturing_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Manufacturing_Date.Location = new System.Drawing.Point(503, 168);
            this.lbl_Manufacturing_Date.Name = "lbl_Manufacturing_Date";
            this.lbl_Manufacturing_Date.Size = new System.Drawing.Size(366, 41);
            this.lbl_Manufacturing_Date.TabIndex = 11;
            this.lbl_Manufacturing_Date.Text = "Manufacturing Date";
            // 
            // frm_View_Product_Dynamically
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1885, 887);
            this.ControlBox = false;
            this.Controls.Add(this.dtp_Manufacturing_Date);
            this.Controls.Add(this.lbl_Manufacturing_Date);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_View_Product_Dynamically);
            this.Controls.Add(this.lbl_View_Product_Details);
            this.Name = "frm_View_Product_Dynamically";
            this.Text = "View Product Dynamically";
            this.Load += new System.EventHandler(this.frm_View_Product_Dynamically_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Product_Dynamically)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Product_Details;
        private System.Windows.Forms.DataGridView dgv_View_Product_Dynamically;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DateTimePicker dtp_Manufacturing_Date;
        private System.Windows.Forms.Label lbl_Manufacturing_Date;
    }
}