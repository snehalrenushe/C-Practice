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
    public partial class frm_View_Product_Details : Form
    {
        public frm_View_Product_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Product_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Product_Management_SystemDataSet.Product_Details' table. You can move, or remove it, as needed.
            this.product_DetailsTableAdapter.Fill(this.dB_Product_Management_SystemDataSet.Product_Details);

        }
    }
}
