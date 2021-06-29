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
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
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

        void Clear_Controls()
        {
            tb_Roll_No.Clear();

            tb_Name.Clear();
            dtp_Date_Of_Birth.ResetText();
            tb_Mobile_No.Clear();
            cb_Course.SelectedIndex = -1;

            tb_Roll_No.Focus();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();

            ANS.Show();

            this.Hide();
        }

        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            frm_All_Student_List ASL = new frm_All_Student_List();

            ASL.Show();

            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Logging Out", "Are you Sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();

                this.Hide();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cb_Course.ResetText();

            tb_Roll_No.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Roll_No.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * From Student_Details Where Roll_No = " + tb_Roll_No.Text + " ";

                var Obj = Cmd.ExecuteReader();             //SqlDataReader Obj = Cmd.ExecuteReader(); 

                if (Obj.Read())
                {
                    tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                    dtp_Date_Of_Birth.Text = (Obj["DOB"].ToString());
                    tb_Mobile_No.Text = (Obj["Mobile_No"].ToString());
                    cb_Course.Text = Obj.GetString(Obj.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("Information is not Availale which You are searching", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Clear_Controls();
                }

                Con_Close();
            }
        }
    }
}
