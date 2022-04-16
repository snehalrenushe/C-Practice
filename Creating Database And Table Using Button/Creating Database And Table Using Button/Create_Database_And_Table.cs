using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Creating_Database_And_Table_Using_Button
{
    public partial class Create_Database_And_Table : Form
    {
        public Create_Database_And_Table()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Database.Clear();
            tb_Table_Name.Clear();

            tb_Database.Focus();
        }

        void Creating_Database()
        {
            System.Data.SqlClient.SqlConnection Con;

            string createDB;

            Con = new SqlConnection();

            Con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=;Integrated Security=True";

            createDB = "Create Database " + tb_Database.Text + "";

            SqlCommand Cmd = new SqlCommand(createDB, Con);

            Con.Open();
            MessageBox.Show(createDB);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Database has been created successfully!", "Create Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Con.Close();

        }

        void Creating_Table()
        {
            System.Data.SqlClient.SqlConnection Con;

            string createtb;

            Con = new SqlConnection();

            Con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=;Integrated Security=True";

            createtb = "Create table " + tb_Table_Name.Text + "(Student_ID int,Student_Name varchar(50))";

            SqlCommand Cmd = new SqlCommand(createtb, Con);

            Con.Open();
            MessageBox.Show(createtb);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Table has been created successfully!", "Create Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Con.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Creating_Database();

            Creating_Table();

            Clear_Controls();
        }

    }
}
