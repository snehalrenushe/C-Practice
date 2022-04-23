using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System
{
    public partial class frm_View_Expense_Details : Form
    {
        public frm_View_Expense_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Expense_Details_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);
        }
    }
}
