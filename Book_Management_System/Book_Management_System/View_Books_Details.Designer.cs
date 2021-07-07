namespace Book_Management_System
{
    partial class frm_View_Books_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Book_Details = new System.Windows.Forms.DataGridView();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Add_New_Book = new System.Windows.Forms.Button();
            this.dB_Book_Management_SystemDataSet = new Book_Management_System.DB_Book_Management_SystemDataSet();
            this.dBBookManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Book_Management_SystemDataSet1 = new Book_Management_System.DB_Book_Management_SystemDataSet1();
            this.bookDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_DetailsTableAdapter = new Book_Management_System.DB_Book_Management_SystemDataSet1TableAdapters.Book_DetailsTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dB_Book_Management_SystemDataSet2 = new Book_Management_System.DB_Book_Management_SystemDataSet2();
            this.bookDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.book_DetailsTableAdapter1 = new Book_Management_System.DB_Book_Management_SystemDataSet2TableAdapters.Book_DetailsTableAdapter();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Book_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBookManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Book_Management_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Book_Management_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Book_Details
            // 
            this.dgv_Book_Details.AllowUserToAddRows = false;
            this.dgv_Book_Details.AllowUserToDeleteRows = false;
            this.dgv_Book_Details.AutoGenerateColumns = false;
            this.dgv_Book_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Book_Details.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Book_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Book_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn});
            this.dgv_Book_Details.DataSource = this.bookDetailsBindingSource1;
            this.dgv_Book_Details.Location = new System.Drawing.Point(29, 144);
            this.dgv_Book_Details.Name = "dgv_Book_Details";
            this.dgv_Book_Details.ReadOnly = true;
            this.dgv_Book_Details.RowTemplate.Height = 28;
            this.dgv_Book_Details.Size = new System.Drawing.Size(1205, 418);
            this.dgv_Book_Details.TabIndex = 0;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Header.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Header.Location = new System.Drawing.Point(411, 36);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(429, 60);
            this.lbl_Header.TabIndex = 2;
            this.lbl_Header.Text = "View Book List";
            // 
            // btn_Add_New_Book
            // 
            this.btn_Add_New_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Add_New_Book.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Book.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Add_New_Book.Location = new System.Drawing.Point(513, 585);
            this.btn_Add_New_Book.Name = "btn_Add_New_Book";
            this.btn_Add_New_Book.Size = new System.Drawing.Size(291, 53);
            this.btn_Add_New_Book.TabIndex = 16;
            this.btn_Add_New_Book.Text = "Add_New_Books";
            this.btn_Add_New_Book.UseVisualStyleBackColor = false;
            this.btn_Add_New_Book.Click += new System.EventHandler(this.btn_Add_New_Book_Click);
            // 
            // dB_Book_Management_SystemDataSet
            // 
            this.dB_Book_Management_SystemDataSet.DataSetName = "DB_Book_Management_SystemDataSet";
            this.dB_Book_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBBookManagementSystemDataSetBindingSource
            // 
            this.dBBookManagementSystemDataSetBindingSource.DataSource = this.dB_Book_Management_SystemDataSet;
            this.dBBookManagementSystemDataSetBindingSource.Position = 0;
            // 
            // dB_Book_Management_SystemDataSet1
            // 
            this.dB_Book_Management_SystemDataSet1.DataSetName = "DB_Book_Management_SystemDataSet1";
            this.dB_Book_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDetailsBindingSource
            // 
            this.bookDetailsBindingSource.DataMember = "Book_Details";
            this.bookDetailsBindingSource.DataSource = this.dB_Book_Management_SystemDataSet1;
            // 
            // book_DetailsTableAdapter
            // 
            this.book_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            this.publishDateDataGridViewTextBoxColumn.DataPropertyName = "Publish_Date";
            this.publishDateDataGridViewTextBoxColumn.HeaderText = "Publish_Date";
            this.publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            this.publishDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "Book_Price";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "Book_Price";
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dB_Book_Management_SystemDataSet2
            // 
            this.dB_Book_Management_SystemDataSet2.DataSetName = "DB_Book_Management_SystemDataSet2";
            this.dB_Book_Management_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDetailsBindingSource1
            // 
            this.bookDetailsBindingSource1.DataMember = "Book_Details";
            this.bookDetailsBindingSource1.DataSource = this.dB_Book_Management_SystemDataSet2;
            // 
            // book_DetailsTableAdapter1
            // 
            this.book_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Log_Out.Location = new System.Drawing.Point(1120, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(134, 46);
            this.btn_Log_Out.TabIndex = 17;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // frm_View_Books_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1279, 674);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Add_New_Book);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.dgv_Book_Details);
            this.Name = "frm_View_Books_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Books Details";
            this.Load += new System.EventHandler(this.frm_View_Books_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Book_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBookManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Book_Management_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Book_Management_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Book_Details;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Add_New_Book;
        private System.Windows.Forms.BindingSource dBBookManagementSystemDataSetBindingSource;
        private DB_Book_Management_SystemDataSet dB_Book_Management_SystemDataSet;
        private DB_Book_Management_SystemDataSet1 dB_Book_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource;
        private DB_Book_Management_SystemDataSet1TableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
        private DB_Book_Management_SystemDataSet2 dB_Book_Management_SystemDataSet2;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource1;
        private DB_Book_Management_SystemDataSet2TableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter1;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}