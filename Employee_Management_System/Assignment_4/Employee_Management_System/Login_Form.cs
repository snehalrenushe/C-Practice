using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Employee_Management_System;Integrated Security=True");

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

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = " Select * from Login_Details where Username = @Uname And Password = @pass";

            Cmd.Parameters.Add("Uname",SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pass",SqlDbType.NVarChar).Value = tb_Password.Text;

            string Ret = Convert.ToString(Cmd.ExecuteScalar());

            if(Ret == tb_Username.Text && tb_Username.Text != "")
            {
                Global_Vars.Uname = tb_Username.Text;

                if (tb_Username.Text == "admin")
                {
                    Global_Vars.User_Role = 1;
                }

                MessageBox.Show("Login Successfull !!","Working",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
                MDI_Employee_Management_System EMS = new MDI_Employee_Management_System();

                EMS.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username & Password","Incorrect",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            Con_Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
