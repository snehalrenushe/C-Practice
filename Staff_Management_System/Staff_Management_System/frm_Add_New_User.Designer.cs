namespace Staff_Management_System
{
    partial class frm_Add_New_User
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
            this.lbl_User_Management = new System.Windows.Forms.Label();
            this.tc_User_Management = new System.Windows.Forms.TabControl();
            this.tp_Add_New_User = new System.Windows.Forms.TabPage();
            this.lbl_Add_User = new System.Windows.Forms.Label();
            this.cb_Add_Username = new System.Windows.Forms.ComboBox();
            this.tb_Add_Confirm_Password = new System.Windows.Forms.TextBox();
            this.lbl_Add_Confirm_Password = new System.Windows.Forms.Label();
            this.tb_Add_Password = new System.Windows.Forms.TextBox();
            this.cb_Add_User_Role = new System.Windows.Forms.ComboBox();
            this.btn_Add_Submit = new System.Windows.Forms.Button();
            this.lbl_Add_Password = new System.Windows.Forms.Label();
            this.lbl_Add_Username = new System.Windows.Forms.Label();
            this.lbl_Add_User_Role = new System.Windows.Forms.Label();
            this.tp_Update_User = new System.Windows.Forms.TabPage();
            this.lbl_Update_User = new System.Windows.Forms.Label();
            this.cb_Update_Username = new System.Windows.Forms.ComboBox();
            this.tb_Update_Confirm_Password = new System.Windows.Forms.TextBox();
            this.lbl_Update_Confirm_Password = new System.Windows.Forms.Label();
            this.tb_Update_New_Password = new System.Windows.Forms.TextBox();
            this.cb_Update_User_Role = new System.Windows.Forms.ComboBox();
            this.btn_Update_Submit = new System.Windows.Forms.Button();
            this.lbl_Update_New_Password = new System.Windows.Forms.Label();
            this.lbl_Update_Username = new System.Windows.Forms.Label();
            this.lbl_Update_User_Role = new System.Windows.Forms.Label();
            this.tp_Delete_User = new System.Windows.Forms.TabPage();
            this.lbl_Delete_User = new System.Windows.Forms.Label();
            this.cb_Delete_Username = new System.Windows.Forms.ComboBox();
            this.tb_Delete_Admin_Password = new System.Windows.Forms.TextBox();
            this.cb_Delete_User_Role = new System.Windows.Forms.ComboBox();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.lbl_Delete_Admin_Password = new System.Windows.Forms.Label();
            this.lbl_Delete_Username = new System.Windows.Forms.Label();
            this.lbl_Delete_User_Role = new System.Windows.Forms.Label();
            this.tc_User_Management.SuspendLayout();
            this.tp_Add_New_User.SuspendLayout();
            this.tp_Update_User.SuspendLayout();
            this.tp_Delete_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_User_Management
            // 
            this.lbl_User_Management.AutoSize = true;
            this.lbl_User_Management.BackColor = System.Drawing.Color.OldLace;
            this.lbl_User_Management.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Management.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_User_Management.Location = new System.Drawing.Point(708, 32);
            this.lbl_User_Management.Name = "lbl_User_Management";
            this.lbl_User_Management.Size = new System.Drawing.Size(631, 83);
            this.lbl_User_Management.TabIndex = 16;
            this.lbl_User_Management.Text = "User Management";
            // 
            // tc_User_Management
            // 
            this.tc_User_Management.Controls.Add(this.tp_Add_New_User);
            this.tc_User_Management.Controls.Add(this.tp_Update_User);
            this.tc_User_Management.Controls.Add(this.tp_Delete_User);
            this.tc_User_Management.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tc_User_Management.Location = new System.Drawing.Point(286, 180);
            this.tc_User_Management.Name = "tc_User_Management";
            this.tc_User_Management.SelectedIndex = 0;
            this.tc_User_Management.Size = new System.Drawing.Size(1420, 611);
            this.tc_User_Management.TabIndex = 17;
            // 
            // tp_Add_New_User
            // 
            this.tp_Add_New_User.Controls.Add(this.lbl_Add_User);
            this.tp_Add_New_User.Controls.Add(this.cb_Add_Username);
            this.tp_Add_New_User.Controls.Add(this.tb_Add_Confirm_Password);
            this.tp_Add_New_User.Controls.Add(this.lbl_Add_Confirm_Password);
            this.tp_Add_New_User.Controls.Add(this.tb_Add_Password);
            this.tp_Add_New_User.Controls.Add(this.cb_Add_User_Role);
            this.tp_Add_New_User.Controls.Add(this.btn_Add_Submit);
            this.tp_Add_New_User.Controls.Add(this.lbl_Add_Password);
            this.tp_Add_New_User.Controls.Add(this.lbl_Add_Username);
            this.tp_Add_New_User.Controls.Add(this.lbl_Add_User_Role);
            this.tp_Add_New_User.Location = new System.Drawing.Point(4, 45);
            this.tp_Add_New_User.Name = "tp_Add_New_User";
            this.tp_Add_New_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Add_New_User.Size = new System.Drawing.Size(1412, 562);
            this.tp_Add_New_User.TabIndex = 0;
            this.tp_Add_New_User.Text = "Add New User";
            this.tp_Add_New_User.UseVisualStyleBackColor = true;
            // 
            // lbl_Add_User
            // 
            this.lbl_Add_User.AutoSize = true;
            this.lbl_Add_User.BackColor = System.Drawing.Color.White;
            this.lbl_Add_User.Font = new System.Drawing.Font("Rockwell", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_User.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Add_User.Location = new System.Drawing.Point(500, 25);
            this.lbl_Add_User.Name = "lbl_Add_User";
            this.lbl_Add_User.Size = new System.Drawing.Size(307, 72);
            this.lbl_Add_User.TabIndex = 27;
            this.lbl_Add_User.Text = "Add User";
            // 
            // cb_Add_Username
            // 
            this.cb_Add_Username.Font = new System.Drawing.Font("Rockwell", 14F);
            this.cb_Add_Username.FormattingEnabled = true;
            this.cb_Add_Username.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cb_Add_Username.Location = new System.Drawing.Point(756, 228);
            this.cb_Add_Username.Name = "cb_Add_Username";
            this.cb_Add_Username.Size = new System.Drawing.Size(393, 39);
            this.cb_Add_Username.TabIndex = 26;
            // 
            // tb_Add_Confirm_Password
            // 
            this.tb_Add_Confirm_Password.Font = new System.Drawing.Font("Rockwell", 12F);
            this.tb_Add_Confirm_Password.Location = new System.Drawing.Point(756, 403);
            this.tb_Add_Confirm_Password.MaxLength = 10;
            this.tb_Add_Confirm_Password.Multiline = true;
            this.tb_Add_Confirm_Password.Name = "tb_Add_Confirm_Password";
            this.tb_Add_Confirm_Password.Size = new System.Drawing.Size(393, 49);
            this.tb_Add_Confirm_Password.TabIndex = 25;
            // 
            // lbl_Add_Confirm_Password
            // 
            this.lbl_Add_Confirm_Password.AutoSize = true;
            this.lbl_Add_Confirm_Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Add_Confirm_Password.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Confirm_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_Confirm_Password.Location = new System.Drawing.Point(224, 406);
            this.lbl_Add_Confirm_Password.Name = "lbl_Add_Confirm_Password";
            this.lbl_Add_Confirm_Password.Size = new System.Drawing.Size(358, 46);
            this.lbl_Add_Confirm_Password.TabIndex = 24;
            this.lbl_Add_Confirm_Password.Text = "Confirm Password";
            // 
            // tb_Add_Password
            // 
            this.tb_Add_Password.Font = new System.Drawing.Font("Rockwell", 12F);
            this.tb_Add_Password.Location = new System.Drawing.Point(756, 316);
            this.tb_Add_Password.MaxLength = 10;
            this.tb_Add_Password.Multiline = true;
            this.tb_Add_Password.Name = "tb_Add_Password";
            this.tb_Add_Password.Size = new System.Drawing.Size(393, 49);
            this.tb_Add_Password.TabIndex = 23;
            // 
            // cb_Add_User_Role
            // 
            this.cb_Add_User_Role.Font = new System.Drawing.Font("Rockwell", 14F);
            this.cb_Add_User_Role.FormattingEnabled = true;
            this.cb_Add_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cb_Add_User_Role.Location = new System.Drawing.Point(756, 141);
            this.cb_Add_User_Role.Name = "cb_Add_User_Role";
            this.cb_Add_User_Role.Size = new System.Drawing.Size(393, 39);
            this.cb_Add_User_Role.TabIndex = 21;
            // 
            // btn_Add_Submit
            // 
            this.btn_Add_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_Submit.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_Submit.Location = new System.Drawing.Point(567, 486);
            this.btn_Add_Submit.Name = "btn_Add_Submit";
            this.btn_Add_Submit.Size = new System.Drawing.Size(181, 54);
            this.btn_Add_Submit.TabIndex = 20;
            this.btn_Add_Submit.Text = "Submit";
            this.btn_Add_Submit.UseVisualStyleBackColor = false;
            // 
            // lbl_Add_Password
            // 
            this.lbl_Add_Password.AutoSize = true;
            this.lbl_Add_Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Add_Password.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_Password.Location = new System.Drawing.Point(224, 319);
            this.lbl_Add_Password.Name = "lbl_Add_Password";
            this.lbl_Add_Password.Size = new System.Drawing.Size(196, 46);
            this.lbl_Add_Password.TabIndex = 19;
            this.lbl_Add_Password.Text = "Password";
            // 
            // lbl_Add_Username
            // 
            this.lbl_Add_Username.AutoSize = true;
            this.lbl_Add_Username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Add_Username.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Username.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_Username.Location = new System.Drawing.Point(224, 228);
            this.lbl_Add_Username.Name = "lbl_Add_Username";
            this.lbl_Add_Username.Size = new System.Drawing.Size(207, 46);
            this.lbl_Add_Username.TabIndex = 18;
            this.lbl_Add_Username.Text = "Username";
            // 
            // lbl_Add_User_Role
            // 
            this.lbl_Add_User_Role.AutoSize = true;
            this.lbl_Add_User_Role.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Add_User_Role.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_User_Role.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_User_Role.Location = new System.Drawing.Point(224, 141);
            this.lbl_Add_User_Role.Name = "lbl_Add_User_Role";
            this.lbl_Add_User_Role.Size = new System.Drawing.Size(197, 46);
            this.lbl_Add_User_Role.TabIndex = 17;
            this.lbl_Add_User_Role.Text = "User Role";
            // 
            // tp_Update_User
            // 
            this.tp_Update_User.Controls.Add(this.lbl_Update_User);
            this.tp_Update_User.Controls.Add(this.cb_Update_Username);
            this.tp_Update_User.Controls.Add(this.tb_Update_Confirm_Password);
            this.tp_Update_User.Controls.Add(this.lbl_Update_Confirm_Password);
            this.tp_Update_User.Controls.Add(this.tb_Update_New_Password);
            this.tp_Update_User.Controls.Add(this.cb_Update_User_Role);
            this.tp_Update_User.Controls.Add(this.btn_Update_Submit);
            this.tp_Update_User.Controls.Add(this.lbl_Update_New_Password);
            this.tp_Update_User.Controls.Add(this.lbl_Update_Username);
            this.tp_Update_User.Controls.Add(this.lbl_Update_User_Role);
            this.tp_Update_User.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tp_Update_User.Location = new System.Drawing.Point(4, 45);
            this.tp_Update_User.Name = "tp_Update_User";
            this.tp_Update_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Update_User.Size = new System.Drawing.Size(1412, 562);
            this.tp_Update_User.TabIndex = 1;
            this.tp_Update_User.Text = "Update User";
            this.tp_Update_User.UseVisualStyleBackColor = true;
            // 
            // lbl_Update_User
            // 
            this.lbl_Update_User.AutoSize = true;
            this.lbl_Update_User.BackColor = System.Drawing.Color.White;
            this.lbl_Update_User.Font = new System.Drawing.Font("Rockwell", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_User.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Update_User.Location = new System.Drawing.Point(473, 24);
            this.lbl_Update_User.Name = "lbl_Update_User";
            this.lbl_Update_User.Size = new System.Drawing.Size(395, 72);
            this.lbl_Update_User.TabIndex = 37;
            this.lbl_Update_User.Text = "Update User";
            // 
            // cb_Update_Username
            // 
            this.cb_Update_Username.Font = new System.Drawing.Font("Rockwell", 14F);
            this.cb_Update_Username.FormattingEnabled = true;
            this.cb_Update_Username.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cb_Update_Username.Location = new System.Drawing.Point(729, 227);
            this.cb_Update_Username.Name = "cb_Update_Username";
            this.cb_Update_Username.Size = new System.Drawing.Size(393, 39);
            this.cb_Update_Username.TabIndex = 36;
            // 
            // tb_Update_Confirm_Password
            // 
            this.tb_Update_Confirm_Password.Font = new System.Drawing.Font("Rockwell", 12F);
            this.tb_Update_Confirm_Password.Location = new System.Drawing.Point(729, 402);
            this.tb_Update_Confirm_Password.MaxLength = 10;
            this.tb_Update_Confirm_Password.Multiline = true;
            this.tb_Update_Confirm_Password.Name = "tb_Update_Confirm_Password";
            this.tb_Update_Confirm_Password.Size = new System.Drawing.Size(393, 49);
            this.tb_Update_Confirm_Password.TabIndex = 35;
            // 
            // lbl_Update_Confirm_Password
            // 
            this.lbl_Update_Confirm_Password.AutoSize = true;
            this.lbl_Update_Confirm_Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Update_Confirm_Password.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Confirm_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Update_Confirm_Password.Location = new System.Drawing.Point(197, 405);
            this.lbl_Update_Confirm_Password.Name = "lbl_Update_Confirm_Password";
            this.lbl_Update_Confirm_Password.Size = new System.Drawing.Size(358, 46);
            this.lbl_Update_Confirm_Password.TabIndex = 34;
            this.lbl_Update_Confirm_Password.Text = "Confirm Password";
            // 
            // tb_Update_New_Password
            // 
            this.tb_Update_New_Password.Font = new System.Drawing.Font("Rockwell", 12F);
            this.tb_Update_New_Password.Location = new System.Drawing.Point(729, 315);
            this.tb_Update_New_Password.MaxLength = 10;
            this.tb_Update_New_Password.Multiline = true;
            this.tb_Update_New_Password.Name = "tb_Update_New_Password";
            this.tb_Update_New_Password.Size = new System.Drawing.Size(393, 49);
            this.tb_Update_New_Password.TabIndex = 33;
            // 
            // cb_Update_User_Role
            // 
            this.cb_Update_User_Role.Font = new System.Drawing.Font("Rockwell", 14F);
            this.cb_Update_User_Role.FormattingEnabled = true;
            this.cb_Update_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cb_Update_User_Role.Location = new System.Drawing.Point(729, 140);
            this.cb_Update_User_Role.Name = "cb_Update_User_Role";
            this.cb_Update_User_Role.Size = new System.Drawing.Size(393, 39);
            this.cb_Update_User_Role.TabIndex = 32;
            // 
            // btn_Update_Submit
            // 
            this.btn_Update_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update_Submit.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Update_Submit.Location = new System.Drawing.Point(540, 485);
            this.btn_Update_Submit.Name = "btn_Update_Submit";
            this.btn_Update_Submit.Size = new System.Drawing.Size(181, 54);
            this.btn_Update_Submit.TabIndex = 31;
            this.btn_Update_Submit.Text = "Submit";
            this.btn_Update_Submit.UseVisualStyleBackColor = false;
            // 
            // lbl_Update_New_Password
            // 
            this.lbl_Update_New_Password.AutoSize = true;
            this.lbl_Update_New_Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Update_New_Password.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_New_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Update_New_Password.Location = new System.Drawing.Point(197, 318);
            this.lbl_Update_New_Password.Name = "lbl_Update_New_Password";
            this.lbl_Update_New_Password.Size = new System.Drawing.Size(289, 46);
            this.lbl_Update_New_Password.TabIndex = 30;
            this.lbl_Update_New_Password.Text = "New Password";
            // 
            // lbl_Update_Username
            // 
            this.lbl_Update_Username.AutoSize = true;
            this.lbl_Update_Username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Update_Username.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Username.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Update_Username.Location = new System.Drawing.Point(197, 227);
            this.lbl_Update_Username.Name = "lbl_Update_Username";
            this.lbl_Update_Username.Size = new System.Drawing.Size(207, 46);
            this.lbl_Update_Username.TabIndex = 29;
            this.lbl_Update_Username.Text = "Username";
            // 
            // lbl_Update_User_Role
            // 
            this.lbl_Update_User_Role.AutoSize = true;
            this.lbl_Update_User_Role.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Update_User_Role.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_User_Role.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Update_User_Role.Location = new System.Drawing.Point(197, 140);
            this.lbl_Update_User_Role.Name = "lbl_Update_User_Role";
            this.lbl_Update_User_Role.Size = new System.Drawing.Size(197, 46);
            this.lbl_Update_User_Role.TabIndex = 28;
            this.lbl_Update_User_Role.Text = "User Role";
            // 
            // tp_Delete_User
            // 
            this.tp_Delete_User.Controls.Add(this.lbl_Delete_User);
            this.tp_Delete_User.Controls.Add(this.cb_Delete_Username);
            this.tp_Delete_User.Controls.Add(this.tb_Delete_Admin_Password);
            this.tp_Delete_User.Controls.Add(this.cb_Delete_User_Role);
            this.tp_Delete_User.Controls.Add(this.btn_Delete_User);
            this.tp_Delete_User.Controls.Add(this.lbl_Delete_Admin_Password);
            this.tp_Delete_User.Controls.Add(this.lbl_Delete_Username);
            this.tp_Delete_User.Controls.Add(this.lbl_Delete_User_Role);
            this.tp_Delete_User.Location = new System.Drawing.Point(4, 45);
            this.tp_Delete_User.Name = "tp_Delete_User";
            this.tp_Delete_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Delete_User.Size = new System.Drawing.Size(1412, 562);
            this.tp_Delete_User.TabIndex = 2;
            this.tp_Delete_User.Text = "Delete User";
            this.tp_Delete_User.UseVisualStyleBackColor = true;
            // 
            // lbl_Delete_User
            // 
            this.lbl_Delete_User.AutoSize = true;
            this.lbl_Delete_User.BackColor = System.Drawing.Color.White;
            this.lbl_Delete_User.Font = new System.Drawing.Font("Rockwell", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_User.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Delete_User.Location = new System.Drawing.Point(473, 24);
            this.lbl_Delete_User.Name = "lbl_Delete_User";
            this.lbl_Delete_User.Size = new System.Drawing.Size(378, 72);
            this.lbl_Delete_User.TabIndex = 47;
            this.lbl_Delete_User.Text = "Delete User";
            // 
            // cb_Delete_Username
            // 
            this.cb_Delete_Username.Font = new System.Drawing.Font("Rockwell", 14F);
            this.cb_Delete_Username.FormattingEnabled = true;
            this.cb_Delete_Username.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cb_Delete_Username.Location = new System.Drawing.Point(729, 227);
            this.cb_Delete_Username.Name = "cb_Delete_Username";
            this.cb_Delete_Username.Size = new System.Drawing.Size(393, 39);
            this.cb_Delete_Username.TabIndex = 46;
            // 
            // tb_Delete_Admin_Password
            // 
            this.tb_Delete_Admin_Password.Font = new System.Drawing.Font("Rockwell", 12F);
            this.tb_Delete_Admin_Password.Location = new System.Drawing.Point(729, 315);
            this.tb_Delete_Admin_Password.MaxLength = 10;
            this.tb_Delete_Admin_Password.Multiline = true;
            this.tb_Delete_Admin_Password.Name = "tb_Delete_Admin_Password";
            this.tb_Delete_Admin_Password.Size = new System.Drawing.Size(393, 49);
            this.tb_Delete_Admin_Password.TabIndex = 43;
            // 
            // cb_Delete_User_Role
            // 
            this.cb_Delete_User_Role.Font = new System.Drawing.Font("Rockwell", 14F);
            this.cb_Delete_User_Role.FormattingEnabled = true;
            this.cb_Delete_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cb_Delete_User_Role.Location = new System.Drawing.Point(729, 140);
            this.cb_Delete_User_Role.Name = "cb_Delete_User_Role";
            this.cb_Delete_User_Role.Size = new System.Drawing.Size(393, 39);
            this.cb_Delete_User_Role.TabIndex = 42;
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Delete_User.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete_User.Location = new System.Drawing.Point(528, 434);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(181, 54);
            this.btn_Delete_User.TabIndex = 41;
            this.btn_Delete_User.Text = "Submit";
            this.btn_Delete_User.UseVisualStyleBackColor = false;
            // 
            // lbl_Delete_Admin_Password
            // 
            this.lbl_Delete_Admin_Password.AutoSize = true;
            this.lbl_Delete_Admin_Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Delete_Admin_Password.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Admin_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Delete_Admin_Password.Location = new System.Drawing.Point(197, 318);
            this.lbl_Delete_Admin_Password.Name = "lbl_Delete_Admin_Password";
            this.lbl_Delete_Admin_Password.Size = new System.Drawing.Size(329, 46);
            this.lbl_Delete_Admin_Password.TabIndex = 40;
            this.lbl_Delete_Admin_Password.Text = "Admin Password";
            // 
            // lbl_Delete_Username
            // 
            this.lbl_Delete_Username.AutoSize = true;
            this.lbl_Delete_Username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Delete_Username.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Username.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Delete_Username.Location = new System.Drawing.Point(197, 227);
            this.lbl_Delete_Username.Name = "lbl_Delete_Username";
            this.lbl_Delete_Username.Size = new System.Drawing.Size(207, 46);
            this.lbl_Delete_Username.TabIndex = 39;
            this.lbl_Delete_Username.Text = "Username";
            // 
            // lbl_Delete_User_Role
            // 
            this.lbl_Delete_User_Role.AutoSize = true;
            this.lbl_Delete_User_Role.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Delete_User_Role.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_User_Role.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Delete_User_Role.Location = new System.Drawing.Point(197, 140);
            this.lbl_Delete_User_Role.Name = "lbl_Delete_User_Role";
            this.lbl_Delete_User_Role.Size = new System.Drawing.Size(197, 46);
            this.lbl_Delete_User_Role.TabIndex = 38;
            this.lbl_Delete_User_Role.Text = "User Role";
            // 
            // frm_Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 834);
            this.ControlBox = false;
            this.Controls.Add(this.tc_User_Management);
            this.Controls.Add(this.lbl_User_Management);
            this.Name = "frm_Add_New_User";
            this.Text = "Add New User";
            this.tc_User_Management.ResumeLayout(false);
            this.tp_Add_New_User.ResumeLayout(false);
            this.tp_Add_New_User.PerformLayout();
            this.tp_Update_User.ResumeLayout(false);
            this.tp_Update_User.PerformLayout();
            this.tp_Delete_User.ResumeLayout(false);
            this.tp_Delete_User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User_Management;
        private System.Windows.Forms.TabControl tc_User_Management;
        private System.Windows.Forms.TabPage tp_Add_New_User;
        private System.Windows.Forms.TabPage tp_Update_User;
        private System.Windows.Forms.TabPage tp_Delete_User;
        private System.Windows.Forms.ComboBox cb_Add_Username;
        private System.Windows.Forms.TextBox tb_Add_Confirm_Password;
        private System.Windows.Forms.Label lbl_Add_Confirm_Password;
        private System.Windows.Forms.TextBox tb_Add_Password;
        private System.Windows.Forms.ComboBox cb_Add_User_Role;
        private System.Windows.Forms.Button btn_Add_Submit;
        private System.Windows.Forms.Label lbl_Add_Password;
        private System.Windows.Forms.Label lbl_Add_Username;
        private System.Windows.Forms.Label lbl_Add_User_Role;
        private System.Windows.Forms.Label lbl_Add_User;
        private System.Windows.Forms.Label lbl_Update_User;
        private System.Windows.Forms.ComboBox cb_Update_Username;
        private System.Windows.Forms.TextBox tb_Update_Confirm_Password;
        private System.Windows.Forms.Label lbl_Update_Confirm_Password;
        private System.Windows.Forms.TextBox tb_Update_New_Password;
        private System.Windows.Forms.ComboBox cb_Update_User_Role;
        private System.Windows.Forms.Button btn_Update_Submit;
        private System.Windows.Forms.Label lbl_Update_New_Password;
        private System.Windows.Forms.Label lbl_Update_Username;
        private System.Windows.Forms.Label lbl_Update_User_Role;
        private System.Windows.Forms.Label lbl_Delete_User;
        private System.Windows.Forms.ComboBox cb_Delete_Username;
        private System.Windows.Forms.TextBox tb_Delete_Admin_Password;
        private System.Windows.Forms.ComboBox cb_Delete_User_Role;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.Label lbl_Delete_Admin_Password;
        private System.Windows.Forms.Label lbl_Delete_Username;
        private System.Windows.Forms.Label lbl_Delete_User_Role;
    }
}