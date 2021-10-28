using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Product_Management_System
{
    public partial class MDI_Product_Management_System : Form
    {
        public MDI_Product_Management_System()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDI_Product_Management_System_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_Username.Text = "Welcome" + " " + Global_Vars.Uname;


        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product ANP = new frm_Add_New_Product();

            ANP.MdiParent = this;

            ANP.WindowState = FormWindowState.Maximized;

            ANP.Show();
        }

        private void viewProductDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Product_Details VPD = new frm_View_Product_Details();

            VPD.MdiParent = this;

            VPD.WindowState = FormWindowState.Maximized;

            VPD.Show();
        }

        private void viewProductDetailsByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Product_Dynamically VPD = new frm_View_Product_Dynamically();

            VPD.MdiParent = this;

            VPD.WindowState = FormWindowState.Maximized;

            VPD.Show();
        }

        private void searchProductDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Product_Details SPD = new frm_Search_Product_Details();

            SPD.MdiParent = this;

            SPD.WindowState = FormWindowState.Maximized;

            SPD.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void updateProductDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Product_Details UPD = new frm_Update_Product_Details();

            UPD.MdiParent = this;

            UPD.WindowState = FormWindowState.Maximized;

            UPD.Show();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure you want to Log out ?? ", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login l = new frm_Login();

                l.Show();

                this.Hide();
            }
        }

    }
}
