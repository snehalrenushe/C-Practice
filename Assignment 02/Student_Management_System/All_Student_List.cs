using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_All_Student_List : Form
    {
        public frm_All_Student_List()
        {
            InitializeComponent();
        }

        private void All_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Student_Management_SystemDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.dB_Student_Management_SystemDataSet.Student_Details);

        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();

            ANS.Show();

            this.Hide();
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details SSD = new frm_Search_Student_Details();

            SSD.Show();

            this.Hide();
        }

        private void btn_View_Student_By_Course_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details_By_Course VSDBS = new frm_View_Student_Details_By_Course();

            VSDBS.Show();

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
    }
}
