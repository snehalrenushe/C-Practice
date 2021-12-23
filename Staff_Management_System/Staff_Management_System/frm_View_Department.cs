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
    public partial class frm_View_Department : Form
    {
        public frm_View_Department()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_View_Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Staff_Management_SystemDataSet.Department_Details' table. You can move, or remove it, as needed.
            this.department_DetailsTableAdapter.Fill(this.dB_Staff_Management_SystemDataSet.Department_Details);

        }
    }
}
