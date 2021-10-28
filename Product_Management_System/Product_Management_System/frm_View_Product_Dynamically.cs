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
    public partial class frm_View_Product_Dynamically : Form
    {
        public frm_View_Product_Dynamically()
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

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_View_Product_Dynamically.DataSource = " ";

            SqlDataAdapter SDA = new SqlDataAdapter(Query,Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Product_Dynamically.DataSource = dt;

            Con_Close();
        }
        private void frm_View_Product_Dynamically_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void dtp_Manufacturing_Date_ValueChanged(object sender, EventArgs e)
        {
            Bind_Grid("Select * From Product_Details where Manufacturing_Date = '" + dtp_Manufacturing_Date.Text + "' ");
        }
    }
}
