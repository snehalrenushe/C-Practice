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
    public partial class frm_Update_Product_Details : Form
    {
        public frm_Update_Product_Details()
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
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Purchase_Price.Clear();
            tb_Selling_Price.Clear();
            dtp_Manufacturing_Date.ResetText();

            tb_Product_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * From Product_Details Where Product_ID = " + tb_Product_ID.Text + " ";

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Product_Name.Text = obj.GetString(obj.GetOrdinal("Product_Name"));
                tb_Purchase_Price.Text = (obj["Purchase_Price"].ToString());
                tb_Selling_Price.Text = (obj["Selling_Price"].ToString());
                dtp_Manufacturing_Date.Text = (obj["Manufacturing_Date"].ToString());
            }
            else
            {
                MessageBox.Show("Information is not Available which you are Searching ...", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear_Controls();
            }

            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_ID.Text != " " && tb_Product_Name.Text != " " && tb_Purchase_Price.Text != " " && tb_Selling_Price.Text != " " && dtp_Manufacturing_Date.Text != " ")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Product_Details Set Product_Name = @Pname, Purchase_Price = @Pprice ,Selling_Price = @Sprice where Product_ID = @Pid";

                Cmd.Parameters.Add("Pname", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("Pprice",SqlDbType.Money).Value = tb_Purchase_Price.Text;
                Cmd.Parameters.Add("Sprice", SqlDbType.Money).Value = tb_Selling_Price.Text;
                Cmd.Parameters.Add("Pid",SqlDbType.Int).Value = tb_Product_ID.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Records Updated","Updating",MessageBoxButtons.OK,MessageBoxIcon.Information);

                btn_Reset.PerformClick();
            }
            else
            {
                MessageBox.Show("Incomplete Information","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            Con_Close(); 
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Purchase_Price.Clear();
            tb_Selling_Price.Clear();
            dtp_Manufacturing_Date.ResetText();

            tb_Product_ID.Focus();
        }

        private void frm_Update_Product_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
