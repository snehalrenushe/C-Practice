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

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_User ANU = new frm_Add_New_User();

            ANU.MdiParent = this;
            ANU.WindowState = FormWindowState.Maximized;
            ANU.Show();
        }
        private void updateStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDI_Staff_Management_System_Load(object sender, EventArgs e)
        {

        }
        
    }
}
