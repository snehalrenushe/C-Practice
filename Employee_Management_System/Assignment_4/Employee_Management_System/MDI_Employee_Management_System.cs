using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class MDI_Employee_Management_System : Form
    {
        //FormWindowStateprivate int childFormNumber = 0;

        public MDI_Employee_Management_System()
        {
            InitializeComponent();
        }

        private void MDI_Employee_Management_System_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_Username.Text = Global_Vars.Uname;

            if (Global_Vars.User_Role == 1)
            {
                updateEmployeeDetailsToolStripMenuItem.Visible = true;
                viewEmployeeDetailsByDeptToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;
            }
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Employee_Details AED = new frm_Add_Employee_Details();

            AED.MdiParent = this;
            AED.WindowState = FormWindowState.Maximized;
            AED.Show();
        }

        private void searchEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee_Details SED = new frm_Search_Employee_Details();

            SED.MdiParent = this;
            SED.WindowState = FormWindowState.Maximized;
            SED.Show();
        }

        private void viewEmployeeDetailsByDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee_Details_By_Department SEDBD= new frm_Search_Employee_Details_By_Department();

            SEDBD.MdiParent = this;
            SEDBD.WindowState = FormWindowState.Maximized;
            SEDBD.Show();
        }

        private void viewEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Employee_Details VED = new frm_View_Employee_Details();

            VED.MdiParent = this;
            VED.WindowState = FormWindowState.Maximized;
            VED.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Logging Out", "Are you Sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                updateEmployeeDetailsToolStripMenuItem.Visible = false;
                viewEmployeeDetailsByDeptToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;

                Global_Vars.User_Role = 0;

                frm_Login Obj = new frm_Login();
                Obj.Show();

                this.Hide();
            }
        }

        private void updateEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Employee_Details UED = new frm_Update_Employee_Details();

            UED.MdiParent = this;
            UED.WindowState = FormWindowState.Maximized;
            UED.Show();
        }
    }
}
