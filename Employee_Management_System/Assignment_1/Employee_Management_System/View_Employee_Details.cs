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
    public partial class frm_View_Employee_Details : Form
    {
        public frm_View_Employee_Details()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_Employee_Details AED = new frm_Add_Employee_Details();

            AED.Show();

            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you Sure you want to Log Out ??","Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login Login = new frm_Login();

                Login.Show();

                this.Hide();
            }
        }

        private void frm_View_Employee_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Employee_Management_SystemDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.dB_Employee_Management_SystemDataSet.Employee_Details);

        }
    }
}
