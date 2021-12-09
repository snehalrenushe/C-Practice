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
    public partial class frm_Add_New_Student : Form
    {
        global Gobj = new global();
        Add_Student AS = new Add_Student();

        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = Gobj.Auto_Increament("Select Count(*) From Student_Details", "Select Max(Roll_No) From Student_Details", 1).ToString();

            tb_Name.Clear();
            dtp_Date_Of_Birth.ResetText();
            tb_Mobile_No.Clear();
            cb_Course.SelectedIndex = -1;

            tb_Roll_No.Focus();
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

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && dtp_Date_Of_Birth.Text != "" && tb_Mobile_No.TextLength == 10 && cb_Course.Text != "")
            {
                AS.insertrecord("Insert into Student_Details(Roll_No,Name,DOB,Mobile_No,Course) VALUES (" + tb_Roll_No.Text + " , '" + tb_Name.Text + "', '" + dtp_Date_Of_Birth.Text + "'," + tb_Mobile_No.Text + ",'" + cb_Course.Text + "')");

                MessageBox.Show("Details Saved Sucessfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Incomplete Information..");
            }

            Clear_Controls();

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
    }
}
