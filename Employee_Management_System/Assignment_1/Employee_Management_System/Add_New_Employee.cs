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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Emp_ID.Text != "" && tb_Name.Text != "" && tb_Post.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = " INSERT INTO Employee_Details (Emp_ID, Name, DOB, Post) VALUES (@Emp_ID,@Name,@Date_Of_Birth,@Post) ";

                Cmd.Parameters.Add("Emp_ID", SqlDbType.Int).Value = tb_Emp_ID.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Date_Of_Birth", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("Post", SqlDbType.NVarChar).Value = tb_Post.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Sucessfully!!!","Saving",MessageBoxButtons.OK,MessageBoxIcon.Information);

                tb_Emp_ID.Clear();
                tb_Name.Clear();
                tb_Post.Clear();
                dtp_Date_Of_Birth.ResetText();

                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information..");
            }
        }

        private void btn_View_All_Employee_Click(object sender, EventArgs e)
        {
            frm_View_All_Employee VAE = new frm_View_All_Employee();

            VAE.Show();

            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Logging Out","Are you Sure?" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Form Lf = new frm_Login_Form();

                Lf.Show();

                this.Hide();
            }
        }


    }
}
