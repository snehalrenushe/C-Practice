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
    public partial class frm_Update_Employee_Details : Form
    {
        public frm_Update_Employee_Details()
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
            tb_ID.Clear();

            tb_Name.Clear();
            dtp_Date_Of_Birth.ResetText();
            tb_Salary.Clear();
            cb_Department.SelectedIndex = -1;

            tb_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * From Employee_Details Where ID = " + tb_ID.Text + " ";

                var Obj = Cmd.ExecuteReader();             //SqlDataReader Obj = Cmd.ExecuteReader(); 

                if (Obj.Read())
                {
                    tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                    dtp_Date_Of_Birth.Text = (Obj["DOB"].ToString());
                    tb_Salary.Text = (Obj["Salary"].ToString());
                    cb_Department.Text = Obj.GetString(Obj.GetOrdinal("Department"));

                    tb_Name.Enabled = true;
                    tb_Salary.Enabled = true;
                    cb_Department.Enabled = true;
                    tb_ID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Information is not Availale which You are searching", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Clear_Controls();
                }

                Con_Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_ID.Text != "" && tb_Name.Text != "" && dtp_Date_Of_Birth.Text != "" && tb_Salary.Text != "" && cb_Department.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "UPDATE Employee_Details Set Name = @Name,Salary = @Salary,Department = @Department Where ID = @ID";

                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Salary", SqlDbType.Decimal).Value = tb_Salary.Text;
                Cmd.Parameters.Add("Department", SqlDbType.NVarChar).Value = cb_Department.Text;
                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_ID.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Sucessfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_Reset.PerformClick();
            }
            else
            {
                MessageBox.Show("Incomplete Information..");
            }

            Con_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_ID.Enabled = true;
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Salary.Clear();
            cb_Department.ResetText();

            tb_ID.Focus();
        }

        private void frm_Update_Employee_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
