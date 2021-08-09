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
    public partial class frm_Add_Employee_Details : Form
    {
        public frm_Add_Employee_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Employee_Management_System;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Salary.Clear();
            cb_Department.ResetText();
            dtp_Date_Of_Birth.ResetText();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(tb_ID.Text != "" && tb_Name.Text != "" && tb_Salary.Text != "" && cb_Department.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Employee_Details (ID,Name,DOB,Salary,Department) VALUES (@ID,@Name,@DOB,@Salary,@Department)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("Name",SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("Salary", SqlDbType.Int).Value = tb_Salary.Text;
                Cmd.Parameters.Add("Department", SqlDbType.NVarChar).Value = cb_Department.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Records Saved Successfully !! ","Saving",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Clear_Controls();

                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you Sure you want to Log Out ??", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login Login = new frm_Login();

                Login.Show();

                this.Hide();
            }
        }

        private void btn_View_All_Details_Click(object sender, EventArgs e)
        {
            frm_View_Employee_Details VED = new frm_View_Employee_Details();

            VED.Show();

            this.Hide();
        }

    }
}
