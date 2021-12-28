namespace Staff_Management_System
{
    partial class frm_Add_New_Staff
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
            this.tb_Staff_ID = new System.Windows.Forms.TextBox();
            this.lbl_Staff_ID = new System.Windows.Forms.Label();
            this.lbl_Add_Staff = new System.Windows.Forms.Label();
            this.tb_Staff_Name = new System.Windows.Forms.TextBox();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Staff_Name = new System.Windows.Forms.Label();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.cb_Designation = new System.Windows.Forms.ComboBox();
            this.gb_Add_Staff = new System.Windows.Forms.GroupBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.gb_Department = new System.Windows.Forms.GroupBox();
            this.cb_McDonalds = new System.Windows.Forms.CheckBox();
            this.cb_Tata = new System.Windows.Forms.CheckBox();
            this.cb_DMart = new System.Windows.Forms.CheckBox();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.gb_Shift_Timing = new System.Windows.Forms.GroupBox();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Afternoon = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift_Timing = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.lbl_Project = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gb_Add_Staff.SuspendLayout();
            this.gb_Department.SuspendLayout();
            this.gb_Shift_Timing.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Staff_ID
            // 
            this.tb_Staff_ID.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_ID.Location = new System.Drawing.Point(349, 69);
            this.tb_Staff_ID.MaxLength = 10;
            this.tb_Staff_ID.Multiline = true;
            this.tb_Staff_ID.Name = "tb_Staff_ID";
            this.tb_Staff_ID.Size = new System.Drawing.Size(365, 36);
            this.tb_Staff_ID.TabIndex = 10;
            // 
            // lbl_Staff_ID
            // 
            this.lbl_Staff_ID.AutoSize = true;
            this.lbl_Staff_ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Staff_ID.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Staff_ID.Location = new System.Drawing.Point(70, 69);
            this.lbl_Staff_ID.Name = "lbl_Staff_ID";
            this.lbl_Staff_ID.Size = new System.Drawing.Size(117, 36);
            this.lbl_Staff_ID.TabIndex = 13;
            this.lbl_Staff_ID.Text = "Staff ID";
            // 
            // lbl_Add_Staff
            // 
            this.lbl_Add_Staff.AutoSize = true;
            this.lbl_Add_Staff.BackColor = System.Drawing.Color.OldLace;
            this.lbl_Add_Staff.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Staff.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Add_Staff.Location = new System.Drawing.Point(732, 51);
            this.lbl_Add_Staff.Name = "lbl_Add_Staff";
            this.lbl_Add_Staff.Size = new System.Drawing.Size(427, 98);
            this.lbl_Add_Staff.TabIndex = 15;
            this.lbl_Add_Staff.Text = "Add Staff";
            // 
            // tb_Staff_Name
            // 
            this.tb_Staff_Name.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_Name.Location = new System.Drawing.Point(347, 162);
            this.tb_Staff_Name.MaxLength = 30;
            this.tb_Staff_Name.Multiline = true;
            this.tb_Staff_Name.Name = "tb_Staff_Name";
            this.tb_Staff_Name.Size = new System.Drawing.Size(365, 36);
            this.tb_Staff_Name.TabIndex = 17;
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(70, 256);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(202, 36);
            this.lbl_Date_Of_Birth.TabIndex = 16;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // lbl_Staff_Name
            // 
            this.lbl_Staff_Name.AutoSize = true;
            this.lbl_Staff_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Staff_Name.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Staff_Name.Location = new System.Drawing.Point(70, 162);
            this.lbl_Staff_Name.Name = "lbl_Staff_Name";
            this.lbl_Staff_Name.Size = new System.Drawing.Size(171, 36);
            this.lbl_Staff_Name.TabIndex = 18;
            this.lbl_Staff_Name.Text = "Staff Name";
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Designation.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Designation.Location = new System.Drawing.Point(70, 439);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(188, 36);
            this.lbl_Designation.TabIndex = 20;
            this.lbl_Designation.Text = "Designation";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(348, 341);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Multiline = true;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(365, 36);
            this.tb_Mobile_No.TabIndex = 23;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(70, 345);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(165, 36);
            this.lbl_Mobile_No.TabIndex = 22;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Rockwell", 14F);
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(350, 255);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(364, 40);
            this.dtp_Date_Of_Birth.TabIndex = 24;
            // 
            // cb_Designation
            // 
            this.cb_Designation.Font = new System.Drawing.Font("Rockwell", 14F);
            this.cb_Designation.FormattingEnabled = true;
            this.cb_Designation.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "BSC",
            "MBA",
            "BCOM",
            "BA"});
            this.cb_Designation.Location = new System.Drawing.Point(349, 439);
            this.cb_Designation.Name = "cb_Designation";
            this.cb_Designation.Size = new System.Drawing.Size(363, 39);
            this.cb_Designation.TabIndex = 25;
            // 
            // gb_Add_Staff
            // 
            this.gb_Add_Staff.Controls.Add(this.tb_Description);
            this.gb_Add_Staff.Controls.Add(this.clb_Hobbies);
            this.gb_Add_Staff.Controls.Add(this.gb_Department);
            this.gb_Add_Staff.Controls.Add(this.cb_Department);
            this.gb_Add_Staff.Controls.Add(this.gb_Shift_Timing);
            this.gb_Add_Staff.Controls.Add(this.gb_Gender);
            this.gb_Add_Staff.Controls.Add(this.lbl_Gender);
            this.gb_Add_Staff.Controls.Add(this.lbl_Shift_Timing);
            this.gb_Add_Staff.Controls.Add(this.lbl_Hobbies);
            this.gb_Add_Staff.Controls.Add(this.lbl_Project);
            this.gb_Add_Staff.Controls.Add(this.lbl_Department);
            this.gb_Add_Staff.Controls.Add(this.lbl_Staff_ID);
            this.gb_Add_Staff.Controls.Add(this.cb_Designation);
            this.gb_Add_Staff.Controls.Add(this.tb_Staff_ID);
            this.gb_Add_Staff.Controls.Add(this.dtp_Date_Of_Birth);
            this.gb_Add_Staff.Controls.Add(this.lbl_Date_Of_Birth);
            this.gb_Add_Staff.Controls.Add(this.tb_Mobile_No);
            this.gb_Add_Staff.Controls.Add(this.tb_Staff_Name);
            this.gb_Add_Staff.Controls.Add(this.lbl_Mobile_No);
            this.gb_Add_Staff.Controls.Add(this.lbl_Staff_Name);
            this.gb_Add_Staff.Controls.Add(this.lbl_Designation);
            this.gb_Add_Staff.Location = new System.Drawing.Point(171, 191);
            this.gb_Add_Staff.Name = "gb_Add_Staff";
            this.gb_Add_Staff.Size = new System.Drawing.Size(1573, 578);
            this.gb_Add_Staff.TabIndex = 26;
            this.gb_Add_Staff.TabStop = false;
            this.gb_Add_Staff.Text = "Add Staff";
            // 
            // tb_Description
            // 
            this.tb_Description.BackColor = System.Drawing.Color.LightGray;
            this.tb_Description.Enabled = false;
            this.tb_Description.Location = new System.Drawing.Point(1285, 429);
            this.tb_Description.MaxLength = 20;
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(266, 81);
            this.tb_Description.TabIndex = 36;
            this.tb_Description.TextChanged += new System.EventHandler(this.tb_Description_TextChanged);
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Drawing",
            "Reading",
            "Singing",
            "Dancing"});
            this.clb_Hobbies.Location = new System.Drawing.Point(1114, 429);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(165, 124);
            this.clb_Hobbies.TabIndex = 35;
            this.clb_Hobbies.SelectedIndexChanged += new System.EventHandler(this.clb_Hobbies_SelectedIndexChanged);
            // 
            // gb_Department
            // 
            this.gb_Department.Controls.Add(this.cb_McDonalds);
            this.gb_Department.Controls.Add(this.cb_Tata);
            this.gb_Department.Controls.Add(this.cb_DMart);
            this.gb_Department.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Department.Location = new System.Drawing.Point(1114, 314);
            this.gb_Department.Name = "gb_Department";
            this.gb_Department.Size = new System.Drawing.Size(437, 56);
            this.gb_Department.TabIndex = 34;
            this.gb_Department.TabStop = false;
            // 
            // cb_McDonalds
            // 
            this.cb_McDonalds.AutoSize = true;
            this.cb_McDonalds.Location = new System.Drawing.Point(291, 21);
            this.cb_McDonalds.Name = "cb_McDonalds";
            this.cb_McDonalds.Size = new System.Drawing.Size(140, 26);
            this.cb_McDonalds.TabIndex = 2;
            this.cb_McDonalds.Text = "McDonalds";
            this.cb_McDonalds.UseVisualStyleBackColor = true;
            // 
            // cb_Tata
            // 
            this.cb_Tata.AutoSize = true;
            this.cb_Tata.Location = new System.Drawing.Point(158, 21);
            this.cb_Tata.Name = "cb_Tata";
            this.cb_Tata.Size = new System.Drawing.Size(75, 26);
            this.cb_Tata.TabIndex = 1;
            this.cb_Tata.Text = "Tata";
            this.cb_Tata.UseVisualStyleBackColor = true;
            // 
            // cb_DMart
            // 
            this.cb_DMart.AutoSize = true;
            this.cb_DMart.Location = new System.Drawing.Point(6, 21);
            this.cb_DMart.Name = "cb_DMart";
            this.cb_DMart.Size = new System.Drawing.Size(94, 26);
            this.cb_DMart.TabIndex = 0;
            this.cb_DMart.Text = "DMart";
            this.cb_DMart.UseVisualStyleBackColor = true;
            // 
            // cb_Department
            // 
            this.cb_Department.Font = new System.Drawing.Font("Rockwell", 14F);
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Location = new System.Drawing.Point(1114, 249);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(437, 39);
            this.cb_Department.TabIndex = 33;
            // 
            // gb_Shift_Timing
            // 
            this.gb_Shift_Timing.Controls.Add(this.rb_Morning);
            this.gb_Shift_Timing.Controls.Add(this.rb_Night);
            this.gb_Shift_Timing.Controls.Add(this.rb_Afternoon);
            this.gb_Shift_Timing.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Shift_Timing.Location = new System.Drawing.Point(1114, 136);
            this.gb_Shift_Timing.Name = "gb_Shift_Timing";
            this.gb_Shift_Timing.Size = new System.Drawing.Size(437, 62);
            this.gb_Shift_Timing.TabIndex = 32;
            this.gb_Shift_Timing.TabStop = false;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Location = new System.Drawing.Point(6, 25);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(124, 29);
            this.rb_Morning.TabIndex = 40;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Location = new System.Drawing.Point(338, 25);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(93, 29);
            this.rb_Night.TabIndex = 39;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Afternoon
            // 
            this.rb_Afternoon.AutoSize = true;
            this.rb_Afternoon.Location = new System.Drawing.Point(158, 25);
            this.rb_Afternoon.Name = "rb_Afternoon";
            this.rb_Afternoon.Size = new System.Drawing.Size(139, 29);
            this.rb_Afternoon.TabIndex = 38;
            this.rb_Afternoon.TabStop = true;
            this.rb_Afternoon.Text = "Afternoon";
            this.rb_Afternoon.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Rockwell", 14F);
            this.gb_Gender.Location = new System.Drawing.Point(1114, 44);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(437, 60);
            this.gb_Gender.TabIndex = 31;
            this.gb_Gender.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(267, 19);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(133, 35);
            this.rb_Female.TabIndex = 37;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(49, 19);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(103, 35);
            this.rb_Male.TabIndex = 36;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Gender.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Gender.Location = new System.Drawing.Point(839, 68);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(128, 36);
            this.lbl_Gender.TabIndex = 30;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Shift_Timing
            // 
            this.lbl_Shift_Timing.AutoSize = true;
            this.lbl_Shift_Timing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Shift_Timing.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Timing.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Shift_Timing.Location = new System.Drawing.Point(839, 161);
            this.lbl_Shift_Timing.Name = "lbl_Shift_Timing";
            this.lbl_Shift_Timing.Size = new System.Drawing.Size(185, 36);
            this.lbl_Shift_Timing.TabIndex = 29;
            this.lbl_Shift_Timing.Text = "Shift Timing";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Hobbies.Location = new System.Drawing.Point(839, 437);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(139, 36);
            this.lbl_Hobbies.TabIndex = 28;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // lbl_Project
            // 
            this.lbl_Project.AutoSize = true;
            this.lbl_Project.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Project.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Project.Location = new System.Drawing.Point(839, 339);
            this.lbl_Project.Name = "lbl_Project";
            this.lbl_Project.Size = new System.Drawing.Size(117, 36);
            this.lbl_Project.TabIndex = 27;
            this.lbl_Project.Text = "Project";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Department.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Department.Location = new System.Drawing.Point(839, 258);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(190, 36);
            this.lbl_Department.TabIndex = 26;
            this.lbl_Department.Text = "Department";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Submit.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Submit.Location = new System.Drawing.Point(836, 795);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(202, 57);
            this.btn_Submit.TabIndex = 28;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(314, 795);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(202, 57);
            this.btn_Refresh.TabIndex = 27;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Close.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Red;
            this.btn_Close.Location = new System.Drawing.Point(1400, 795);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(202, 57);
            this.btn_Close.TabIndex = 29;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // frm_Add_New_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1002);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Add_Staff);
            this.Controls.Add(this.lbl_Add_Staff);
            this.Name = "frm_Add_New_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Staff_Load);
            this.gb_Add_Staff.ResumeLayout(false);
            this.gb_Add_Staff.PerformLayout();
            this.gb_Department.ResumeLayout(false);
            this.gb_Department.PerformLayout();
            this.gb_Shift_Timing.ResumeLayout(false);
            this.gb_Shift_Timing.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Staff_ID;
        private System.Windows.Forms.Label lbl_Staff_ID;
        private System.Windows.Forms.Label lbl_Add_Staff;
        private System.Windows.Forms.TextBox tb_Staff_Name;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Staff_Name;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.ComboBox cb_Designation;
        private System.Windows.Forms.GroupBox gb_Add_Staff;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.GroupBox gb_Department;
        private System.Windows.Forms.CheckBox cb_McDonalds;
        private System.Windows.Forms.CheckBox cb_Tata;
        private System.Windows.Forms.CheckBox cb_DMart;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.GroupBox gb_Shift_Timing;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Afternoon;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift_Timing;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.Label lbl_Project;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Close;
    }
}