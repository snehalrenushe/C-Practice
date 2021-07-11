using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_View_Student_Details_By_Course : Form
    {
        public frm_View_Student_Details_By_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Student_Management_System;Integrated Security=True");
        
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

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_View_Student_Details_By_Course.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Student_Details_By_Course.DataSource = dt;

            Con_Close();
        }

        private void frm_View_Student_Details_By_Course_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Student_Details");
        }

        private void cb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Student_Details where Course ='" + cb_Course.Text + "' ");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cb_Course.SelectedIndex = -1;

            Bind_Grid("Select * from Student_Details"); 
        }




    }
}
