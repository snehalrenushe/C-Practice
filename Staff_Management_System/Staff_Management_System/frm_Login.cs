using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Staff_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=DB_Staff_Management_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * from Login_Details where User_Role = " + Global_Vars.User_Role + " And Username = '" + cb_Username.Text + "' And Password = '" + tb_Password.Text + "'",Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                MessageBox.Show("Login Successfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global_Vars.Uname = "Welcome " + cb_Username.Text;
                Global_Vars.UID = Convert.ToInt32(Dr["User_Creator_ID"].ToString());

                MDI_Staff_Management_System Obj = new MDI_Staff_Management_System();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Dr.Close();
       
            cb_User_Role.SelectedIndex = 0;
            cb_Username.SelectedIndex = -1;
            tb_Password.Clear();
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;
            cb_User_Role.Focus();

            Con_Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            cb_User_Role.SelectedIndex = 0;
            cb_User_Role.Focus();
        }

        private void cb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            cb_Username.Items.Clear();

            int URole = -1;

            if (cb_User_Role.SelectedIndex == 0)
            {
                URole = 1;
                Global_Vars.User_Role = 1;
            }
            else if (cb_User_Role.SelectedIndex == 1)
            {
                URole = 2;
                Global_Vars.User_Role = 2;
            }
            else if (cb_User_Role.SelectedIndex == 2)
            {
                URole = 3;
                Global_Vars.User_Role = 3;
            }
            else if (cb_User_Role.SelectedIndex == 3)
            {
                URole = 4;
                Global_Vars.User_Role = 4;
            }

            SqlCommand Cmd = new SqlCommand("Select Distinct(Username) from Login_Details where User_Role = " + URole + "",Con);

            SqlDataReader Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }

            Obj.Dispose();

            Con_Close();
        }

        private void cb_Username_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
