using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Staff_Management_System
{
    public partial class MDI_Staff_Management_System : Form
    {

        public MDI_Staff_Management_System()
        {
            InitializeComponent();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Staff ANS = new frm_Add_New_Staff();

            ANS.MdiParent = this;
            ANS.WindowState = FormWindowState.Maximized;
            ANS.Show();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Department AD = new frm_Add_Department();

            AD.MdiParent = this;
            AD.StartPosition = FormStartPosition.CenterScreen;
            AD.Show();
        }

        private void viewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Department VD = new frm_View_Department();

            VD.MdiParent = this;
            VD.WindowState = FormWindowState.Maximized;
            VD.Show();
        }

        private void MDI_Staff_Management_System_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_User.Text = Global_Vars.Uname;
            if (Global_Vars.User_Role == 1)
            {
                userManagementToolStripMenuItem.Visible = true;
            }

        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Management ANU = new frm_User_Management();

            ANU.MdiParent = this;
            ANU.WindowState = FormWindowState.Maximized;
            ANU.Show();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.No;
                
            Res = MessageBox.Show("Logging Out", "Are you Sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                frm_Login LG = new frm_Login();

                LG.Show();

                this.Hide();
            }
        }
        
    }
}
