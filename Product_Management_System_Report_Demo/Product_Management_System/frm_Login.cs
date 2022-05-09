using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Product_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Product_Management_System;Integrated Security=True");

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

        void Clear_Controls()
        {
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * from Login_Details where Username = @uname And Password = @pass";

            Cmd.Parameters.Add("uname", SqlDbType.VarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = tb_Password.Text;

            string Ret = Convert.ToString(Cmd.ExecuteScalar());

            if (Ret == tb_Username.Text && tb_Password.Text != "")
            {
                Global_Vars.Uname = tb_Username.Text;

                MessageBox.Show("Login Successfullyyy !!!","Working",MessageBoxButtons.OK,MessageBoxIcon.Information);

                MDI_Product_Management_System PMS = new MDI_Product_Management_System();

                PMS.WindowState = FormWindowState.Maximized;

                PMS.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username and Password !!!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Clear_Controls();

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
