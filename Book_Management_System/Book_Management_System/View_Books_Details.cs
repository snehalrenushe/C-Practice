using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_Management_System
{
    public partial class frm_View_Books_Details : Form
    {
        public frm_View_Books_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Books_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Book_Management_SystemDataSet2.Book_Details' table. You can move, or remove it, as needed.
            this.book_DetailsTableAdapter1.Fill(this.dB_Book_Management_SystemDataSet2.Book_Details);
            // TODO: This line of code loads data into the 'dB_Book_Management_SystemDataSet1.Book_Details' table. You can move, or remove it, as needed.
            this.book_DetailsTableAdapter.Fill(this.dB_Book_Management_SystemDataSet1.Book_Details);

        }

        private void btn_Add_New_Book_Click(object sender, EventArgs e)
        {
            frm_Accept_Book_Details ABT = new frm_Accept_Book_Details();

            ABT.Show();

            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Logging Out", "Are you Sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();

                this.Hide();
            }
        }
    }
}
