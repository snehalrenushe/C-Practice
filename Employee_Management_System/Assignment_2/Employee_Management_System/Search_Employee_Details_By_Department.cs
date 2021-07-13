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
    public partial class frm_Search_Employee_Details_By_Department : Form
    {
        public frm_Search_Employee_Details_By_Department()
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

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_Employee_Details AED = new frm_Add_Employee_Details();

            AED.Show();

            this.Hide();
        }

        private void btn_View_All_Details_Click(object sender, EventArgs e)
        {
            frm_View_Employee_Details VED = new frm_View_Employee_Details();

            VED.Show();

            this.Hide();
        }

        private void btn_Search_Employee_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Employee_Details SED = new frm_Search_Employee_Details();

            SED.Show();

            this.Hide();
        }

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_Search_Employee_Details_By_Department.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_Search_Employee_Details_By_Department.DataSource = dt;

            Con_Close();
        }

        private void frm_Search_Employee_Details_By_Department_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Employee_Details");
        }

        private void cb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Employee_Details where Department = '" + cb_Department.Text + "' ");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cb_Department.SelectedIndex = -1;

            Bind_Grid("Select * from Employee_Details"); 
        }

    }
}
