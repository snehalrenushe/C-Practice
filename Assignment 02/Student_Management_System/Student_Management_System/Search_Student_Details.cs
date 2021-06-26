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
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
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
    }
}
