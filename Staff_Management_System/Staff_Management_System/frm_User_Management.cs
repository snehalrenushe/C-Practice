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
    public partial class frm_User_Management : Form
    {
        public frm_User_Management()
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

        private void frm_User_Management_Load(object sender, EventArgs e)
        {
            if (Global_Vars.Uname == "Fork")
            {
                cb_Delete_User_Role.Items.Add("Admin");
            }

            cb_Add_User_Role.SelectedIndex = 3;
            cb_Update_User_Role.SelectedIndex = 3;
            cb_Delete_User_Role.SelectedIndex = 2;
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Login_Details where Username = '" + tb_Add_Username.Text + "' ";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (cb_Add_User_Role.Text != "" && tb_Add_Username.Text != "" && tb_Add_Password.Text != "" && tb_Add_Password.Text == tb_Add_Confirm_Password.Text && Cnt == 0)
            {
                Cmd.Dispose();

                Cmd.CommandText = "Insert into Login_Details values(@uname,@pass,@ur,@cid)";
                Cmd.Connection = Con;

                Cmd.Parameters.Add("uname",SqlDbType.NVarChar).Value = tb_Add_Username.Text;
                Cmd.Parameters.Add("pass",SqlDbType.NVarChar).Value = tb_Add_Confirm_Password.Text;
                Cmd.Parameters.Add("ur",SqlDbType.Int).Value = cb_Add_User_Role.SelectedIndex + 1;
                Cmd.Parameters.Add("cid",SqlDbType.Int).Value = Global_Vars.UID;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("User Added Successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);

                tb_Add_Username.Clear();
                tb_Add_Password.Clear();
                tb_Add_Confirm_Password.Clear();
                cb_Add_User_Role.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Same User or Passward Missmatch","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cb_Update_User_Role.Text != "" && cb_Update_Username.Text != "" && tb_Update_New_Password.Text != "" && tb_Update_New_Password.Text == tb_Update_Confirm_Password.Text && cb_Update_Username.Text != "Fork")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Update Login_Details Set Password = @pass where Username = @Uname";
                Cmd.Connection = Con;

                Cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = tb_Update_Confirm_Password.Text;
                Cmd.Parameters.Add("@Uname",SqlDbType.NVarChar).Value = cb_Update_Username.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Password Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cb_Update_Username.SelectedIndex = -1;
                tb_Update_New_Password.Clear();
                tb_Update_Confirm_Password.Clear();
                cb_Update_User_Role.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Invalid Password !!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Login_Details where Password = @pass And User_Role = @URole";

            Cmd.Parameters.Add("@pass",SqlDbType.NVarChar).Value = tb_Delete_Admin_Password.Text;
            Cmd.Parameters.Add("@URole",SqlDbType.Int).Value = 1;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (cb_Delete_User_Role.Text != "" && cb_Delete_Username.Text != "" && cb_Delete_Username.Text != "Fork" && cb_Delete_Username.Text != "Admin" && Cnt > 0)
            {
                Cmd.Dispose();

                Cmd.CommandText = "Delete From Login_Details where Username = @Uname";
                Cmd.Connection = Con;

                Cmd.Parameters.Add("@Uname", SqlDbType.NVarChar).Value = cb_Delete_Username.Text;

                DialogResult Res = System.Windows.Forms.DialogResult.No;

                Res = MessageBox.Show("Are you sure do you really want to Delete these User ", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Res == System.Windows.Forms.DialogResult.Yes)
                {
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("User Deleted Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }     

                cb_Delete_Username.SelectedIndex = -1;
                tb_Delete_Admin_Password.Clear();
                cb_Delete_User_Role.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Invalid Admin Password !!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void cb_Update_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            cb_Update_Username.Items.Clear();

            int URole = cb_Update_User_Role.SelectedIndex + 1; 

            SqlCommand Cmd = new SqlCommand("Select Distinct(Username) from Login_Details where User_Role = " + URole + "", Con);

            SqlDataReader Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Update_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }

            Obj.Dispose();

            Con_Close();
        }

        private void cb_Delete_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            cb_Delete_Username.Items.Clear();

            int URole = cb_Delete_User_Role.SelectedIndex + 2;

            if (cb_Delete_User_Role.Text == "Admin")
            {
                URole = 1;
            }

            SqlCommand Cmd = new SqlCommand("Select Distinct(Username) from Login_Details where User_Role = " + URole + "", Con);

            SqlDataReader Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Delete_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }

            Obj.Dispose();

            Con_Close();

        }

    }
}
