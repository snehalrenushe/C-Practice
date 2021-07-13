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
            tb_ID.Text = Convert.ToString(Auto_Increament());
     
            tb_Name.Clear();
            tb_Salary.Clear();
            cb_Department.ResetText();
            dtp_Date_Of_Birth.ResetText();

            tb_ID.Focus();
        }

        int Auto_Increament()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(ID) From Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_Employee_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
