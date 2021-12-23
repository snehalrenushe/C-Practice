using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Staff_Management_System
{
    public partial class frm_Add_Department : Form
    {
        public frm_Add_Department()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=DB_Staff_Management_System;Integrated Security=True");

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
            tb_Department_ID.Clear();
            tb_Department_Name.Clear();

            tb_Department_ID.Text = Convert.ToString(Auto_Increament());
        }

        private void frm_Add_Department_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        int Auto_Increament()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;

            cmd.CommandText = "Select Count(*) from Department_Details";

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            if (Cnt > 0)
            {
                cmd.Connection = Con;
                cmd.CommandText = "Select Max(Department_ID) from Department_Details";

                Cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }
            
            Con_Close();

            return Cnt;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Department_ID.Text != "" && tb_Department_Name.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Department_Details (Department_ID,Department_Name) values (@ID,@Name)";

                Cmd.Parameters.Add("ID",SqlDbType.Int).Value = tb_Department_ID.Text;
                Cmd.Parameters.Add("Name",SqlDbType.NVarChar).Value = tb_Department_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Records Saved Successfully !! ", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
