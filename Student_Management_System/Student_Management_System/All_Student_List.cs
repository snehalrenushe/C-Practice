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
    public partial class frm_All_Student_List : Form
    {
        public frm_All_Student_List()
        {
            InitializeComponent();
        }

        private void All_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Student_Management_SystemDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.dB_Student_Management_SystemDataSet.Student_Details);

        }

        private void dgv_All_Student_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
