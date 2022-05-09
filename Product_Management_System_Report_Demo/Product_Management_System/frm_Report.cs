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
    public partial class frm_Report : Form
    {
        public frm_Report()
        {
            InitializeComponent();
        }

        private void frm_Report_Load(object sender, EventArgs e)
        {
            CrystalReport1 crpt = new CrystalReport1();

            crpt.Load(@"C:\C#\Product_Management_System\Product_Management_System\CrystalReport1.rpt");

            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
