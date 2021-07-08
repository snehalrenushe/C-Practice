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
    public partial class frm_View_All_Employee : Form
    {
        public frm_View_All_Employee()
        {
            InitializeComponent();
        }

        private void frm_View_All_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Employee_Management_SystemDataSet1.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.dB_Employee_Management_SystemDataSet1.Employee_Details);

        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee ANE = new frm_Add_New_Employee();

            ANE.Show();

            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Logging Out ", "Are you Sure ??" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Form LF = new frm_Login_Form();

                LF.Show();

                this.Hide();
            }
        }

    }
}
