using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Student_Management_System
{
    class Add_Student
    {
        public SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Student_Management_System;Integrated Security=True");

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

        public void insertrecord(string query)
        {
            SqlCommand Cmd = new SqlCommand();

            Con_Open();

            Cmd.Connection = Con;

            Cmd.CommandText = (query);

            Cmd.ExecuteNonQuery();

            Con_Close();
        }
    }
}
