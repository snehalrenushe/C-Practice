using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Management_System
{
    public partial class frm_Accept_Book_Details : Form
    {
        public frm_Accept_Book_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Book_Management_System;Integrated Security=True");

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
            DialogResult Res = MessageBox.Show("Logging Out","Are you Sure??",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();

                this.Hide();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;            
            }
        }

        private void Only_Float_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Book_Id.Text != "" && tb_Book_Name.Text != "" && tb_Book_Price.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = " INSERT INTO Book_Details (Book_ID, Book_Name, Publish_Date, Book_Price) VALUES (@Book_ID,@Book_Name,@Publish_Date,@Book_Price) ";

                Cmd.Parameters.Add("Book_ID", SqlDbType.Int).Value = tb_Book_Id.Text;
                Cmd.Parameters.Add("Book_Name", SqlDbType.NVarChar).Value = tb_Book_Name.Text;
                Cmd.Parameters.Add("Publish_Date", SqlDbType.Date).Value = dtp_Publish_Date.Text;
                Cmd.Parameters.Add("Book_Price", SqlDbType.Money).Value = tb_Book_Price.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Sucessfully!!!","Saving",MessageBoxButtons.OK,MessageBoxIcon.Information);

                tb_Book_Id.Clear();
                tb_Book_Name.Clear();
                tb_Book_Price.Clear();
                dtp_Publish_Date.ResetText();

                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information..");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Book_Id.Text != "" || tb_Book_Name.Text != "" || tb_Book_Price.Text != "")
            {
                Res = MessageBox.Show("Data Entered Will be Lost", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);            
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_View_Book_Details_Click(object sender, EventArgs e)
        {
            frm_View_Books_Details ABD = new frm_View_Books_Details();

            ABD.Show();

            this.Hide();
        }
    }
}
