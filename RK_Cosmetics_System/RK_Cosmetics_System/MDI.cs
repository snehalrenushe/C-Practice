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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(43, 41, 41);

            panel1.BackColor = Color.FromArgb(26, 26, 26);
 
            pnl_Menu.BackColor = Color.FromArgb(43, 41, 41);

            btn_Home.BackColor = Color.FromArgb(43, 41, 41);
            btn_Home.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Customer.BackColor = Color.FromArgb(43, 41, 41);
            btn_Customer.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Employee.BackColor = Color.FromArgb(43, 41, 41);
            btn_Employee.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Distributor.BackColor = Color.FromArgb(43, 41, 41);
            btn_Distributor.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Brand.BackColor = Color.FromArgb(43, 41, 41);
            btn_Brand.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Product.BackColor = Color.FromArgb(43, 41, 41);
            btn_Product.ForeColor = Color.FromArgb(255, 0, 111);
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }

            sliderimg.ImageLocation = string.Format(@"ImagesSlider\{0}.jpg",imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnl_Menu.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnl_Menu.Visible = false;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            btn_Add_New_Customer.BackColor = Color.FromArgb(112, 12, 55);

            btn_View_Customer_List.BackColor = Color.FromArgb(112, 12, 55);
        }

        private void pnl_Employee_Submenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            btn_Add_New_Employee.BackColor = Color.FromArgb(112, 12, 55);

            btn_Update_Employee_Details.BackColor = Color.FromArgb(112, 12, 55);

            btn_View_Employee_List.BackColor = Color.FromArgb(112, 12, 55);
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            btn_Add_New_Distributor.BackColor = Color.FromArgb(112, 12, 55);

            btn_Update_Distributor_Details.BackColor = Color.FromArgb(112, 12, 55);

            btn_View_Distributor_List.BackColor = Color.FromArgb(112, 12, 55);
        }

        private void btn_Brand_Click(object sender, EventArgs e)
        {
            btn_Add_New_Brand.BackColor = Color.FromArgb(112, 12, 55);

            btn_Update_Brand_Details.BackColor = Color.FromArgb(112, 12, 55);

            btn_View_Brand_List.BackColor = Color.FromArgb(112, 12, 55);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            btn_Add_New_Product.BackColor = Color.FromArgb(112, 12, 55);

            btn_Update_Product_Details.BackColor = Color.FromArgb(112, 12, 55);

            btn_View_Product_List.BackColor = Color.FromArgb(112, 12, 55);
        }

    }
}
