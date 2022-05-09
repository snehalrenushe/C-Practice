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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
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
            tb_Product_ID.Text = Convert.ToString(Auto_Increament());

            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Purchase_Price.Clear();
            tb_Selling_Price.Clear();
            dtp_Manufacturing_Date.ResetText();

            tb_Product_ID.Focus();
        }

        int Auto_Increament()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) From Product_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Product_ID) From Product_Details";

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
            Con_Open();

            if(tb_Product_ID.Text != " " && tb_Product_Name.Text != " " && dtp_Manufacturing_Date.Text != " " && tb_Purchase_Price.Text != " " && tb_Selling_Price.Text != " ")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Product_Details (Product_ID,Product_Name,Manufacturing_Date,Purchase_Price,Selling_Price) VALUES (@ID,@Name,@Mdate,@Pprice,@Sprice)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("Mdate", SqlDbType.Date).Value = dtp_Manufacturing_Date.Text;
                Cmd.Parameters.Add("Pprice", SqlDbType.Money).Value = tb_Purchase_Price.Text;
                Cmd.Parameters.Add("Sprice", SqlDbType.Money).Value = tb_Selling_Price.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Records Added Successfully !!! ", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Please Fill Complete Information","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            Con_Close();
            
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            lbl_Logged_In_Username.Text = "Welcome" + " " + Global_Vars.Uname;
            tb_Product_ID.Text = Convert.ToString(Auto_Increament());
        }

        private void tb_Product_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
