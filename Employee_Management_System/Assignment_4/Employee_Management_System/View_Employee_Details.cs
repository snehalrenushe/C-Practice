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

        private void frm_View_Employee_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Employee_Management_SystemDataSet4.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter3.Fill(this.dB_Employee_Management_SystemDataSet4.Employee_Details);
            // TODO: This line of code loads data into the 'dB_Employee_Management_SystemDataSet3.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter2.Fill(this.dB_Employee_Management_SystemDataSet3.Employee_Details);
            // TODO: This line of code loads data into the 'dB_Employee_Management_SystemDataSet2.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter1.Fill(this.dB_Employee_Management_SystemDataSet2.Employee_Details);
            // TODO: This line of code loads data into the 'dB_Employee_Management_SystemDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.dB_Employee_Management_SystemDataSet.Employee_Details);

        }

    }
}
