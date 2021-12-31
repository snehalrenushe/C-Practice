using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Staff_Management_System
{
    public partial class frm_Add_New_Staff : Form
    {
        public frm_Add_New_Staff()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=DB_Staff_Management_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void frm_Add_New_Staff_Load(object sender, EventArgs e)
        {
            tb_Staff_ID.Text = Convert.ToString(Auto_Increament());
            Bind_Department();
        }

        void Bind_Department()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Department_Name from Department_Details";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cb_Department.Items.Add(obj.GetString(obj.GetOrdinal("Department_Name")));              
            }

            obj.Dispose();

            Con_Close();
        }

        int Auto_Increament()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;

            cmd.CommandText = "Select Count(*) from Staff_Details";

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            if (Cnt > 0)
            {
                cmd.Connection = Con;
                cmd.CommandText = "Select Max(Staff_ID) from Staff_Details";

                Cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Staff_ID.Text = Convert.ToString(Auto_Increament());
            tb_Staff_Name.Clear();
            dtp_Date_Of_Birth.ResetText();
            tb_Mobile_No.Clear();
            cb_Designation.ResetText();
            gb_Gender.ResetText();
            gb_Shift_Timing.ResetText();
            cb_Department.ResetText();
            tb_Description.Clear();

            foreach (int itemChecked in clb_Hobbies.CheckedIndices)
            {
                clb_Hobbies.SetItemChecked(itemChecked,false);
            }

            foreach (object itemChecked in clb_Hobbies.CheckedItems)
            {
                clb_Hobbies.SetItemChecked(clb_Hobbies.Items.IndexOf(itemChecked),false);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Gender = " ";
            string Shift = " ";
            string Project = " ";
            string Hobbies = " ";

            if (tb_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Mobile_No.Focus();
                goto DWN;
            }
            if (rb_Male.Checked)
            {
                Gender = rb_Male.Text;
            }
            else
            {
                Gender = rb_Female.Text;
            }

            if (rb_Morning.Checked)
            {
                Shift = rb_Morning.Text;
            }
            else if(rb_Afternoon.Checked)
            {
                Shift = rb_Afternoon.Text;
            }
            else
            {
                Shift = rb_Night.Text;
            }

            if (cb_DMart.Checked)
            {
                Project = cb_DMart.Text;
            }
            if (cb_Tata.Checked)
            {
                Project = cb_Tata.Text;
            }
            if (cb_McDonalds.Checked)
            {
                Project = cb_McDonalds.Text;
            }

            int Cnt = clb_Hobbies.Items.Count;

            for (int i = 0; i <= Cnt - 1 ; i++)
            {
                if (clb_Hobbies.GetItemChecked(i))
                {
                    if (i == Cnt - 1 && tb_Description.Text != " ")
                    {
                        if (Hobbies == "")
                        {
                            Hobbies = tb_Description.Text;
                        }
                        else
                        {
                            Hobbies += " , " + tb_Description.Text;
                        }
                    }
                    else if (Hobbies == "")
                    {
                        Hobbies = clb_Hobbies.Items[i].ToString();
                    }
                    else
                    {
                        Hobbies += " , " + clb_Hobbies.Items[i].ToString();
                    }
                       
                }
            }

            if (tb_Staff_ID.Text != "" && tb_Staff_Name.Text != "" && dtp_Date_Of_Birth.Text != "" && tb_Mobile_No.Text != "" && cb_Designation.Text != "" && cb_Department.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Staff_Details (Staff_ID,Staff_Name,DOB,Mobile_No,Designation,Gender,Shift_Timing,Department,Project,Hobbies,Description) Values (@ID,@Name,@DOB,@Mob,@Desi,'" + Gender + "','" + Shift + "',@Dept,'" + Project + "','" + Hobbies + "',@Des)";

                Cmd.Parameters.Add("ID",SqlDbType.Int).Value = tb_Staff_ID.Text;
                Cmd.Parameters.Add("Name",SqlDbType.NVarChar).Value = tb_Staff_Name.Text;
                Cmd.Parameters.Add("DOB",SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("Mob",SqlDbType.Int).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Desi",SqlDbType.NVarChar).Value = cb_Designation.Text;
                Cmd.Parameters.Add("Dept",SqlDbType.NVarChar).Value = cb_Department.Text;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = tb_Description.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Details Saved Successfully !!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DWN:
            Con_Close();

        }

        private void clb_Hobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Description.Text = clb_Hobbies.Text;
        }

        private void tb_Description_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
