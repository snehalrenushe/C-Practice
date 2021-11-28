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
    public partial class frm_Update_Student_Details : Form
    {
        Add_Student AS = new Add_Student();
        public frm_Update_Student_Details()
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

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Enabled = true;
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

                    tb_Name.Enabled = true;
                    tb_Mobile_No.Enabled = true;
                    cb_Course.Enabled = true;
                    tb_Roll_No.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Information is not Availale which You are searching", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Clear_Controls();
                }

                Con_Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && dtp_Date_Of_Birth.Text != "" && tb_Mobile_No.TextLength == 10 && cb_Course.Text != "")
            {
                AS.insertrecord("UPDATE Student_Details Set Name = '" + tb_Name.Text +"',Mobile_No = " + tb_Mobile_No.Text + ",Course = '" + cb_Course.Text + "' Where Roll_No = " + tb_Roll_No.Text + "");

                MessageBox.Show("Details Saved Sucessfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incomplete Information..");
            }
        }

        private void frm_Update_Student_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}

