﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System
{
    public partial class frm_Add_Expenses : Form
    {
        public frm_Add_Expenses()
        {
            InitializeComponent();
        }

        private void Add_Expenses_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);
        }
    }
}
