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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {

            MDI_Staff_Management_System SMS = new MDI_Staff_Management_System();

            SMS.Show();

            this.Hide();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
