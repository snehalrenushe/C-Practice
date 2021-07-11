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
    public partial class MDI_Student_Management_Application : Form
    {
        public MDI_Student_Management_Application()
        {
            InitializeComponent();
        }

        private void MDI_Student_Management_Application_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_User.Text = Global_Vars.Uname;

            if (Global_Vars.User_Role == 1)
            {
                updateStudentToolStripMenuItem.Visible = true;
                viewByCourseToolStripMenuItem.Visible = true;
                reportsToolStripMenuItem.Visible = true;
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();

            ANS.MdiParent = this;
            ANS.WindowState = FormWindowState.Maximized;
            ANS.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details USD = new frm_Update_Student_Details();

            USD.MdiParent = this;
            USD.WindowState = FormWindowState.Maximized;
            USD.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details SSD = new frm_Search_Student_Details();

            SSD.MdiParent = this;
            SSD.WindowState = FormWindowState.Maximized;
            SSD.Show();
        }

        private void viewByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details_By_Course VSDBC = new frm_View_Student_Details_By_Course();

            VSDBC.MdiParent = this;
            VSDBC.WindowState = FormWindowState.Maximized;
            VSDBC.Show();
        }

        private void viewAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_All_Student_List ASL = new frm_All_Student_List();

            ASL.MdiParent = this;
            ASL.WindowState = FormWindowState.Maximized;
            ASL.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Logging Out", "Are you Sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                updateStudentToolStripMenuItem.Visible = false;
                viewByCourseToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;

                Global_Vars.User_Role = 0;

                frm_Login Obj = new frm_Login();
                Obj.Show();

                this.Hide();
            }
        }
        
    }
}
