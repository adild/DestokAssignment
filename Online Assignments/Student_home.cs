using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Assignments
{
    public partial class Student_home : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Adil\documents\visual studio 2010\Projects\Online Assignments\Online Assignments\OnlineAssDb .mdf;Integrated Security=True;User Instance=True");
        String qs1;
        public Student_home(String qs)
        {
            InitializeComponent();
            qs1 = qs;
            label1.Text = qs;
        }

        private void Student_home_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select NAME from studentReg where USERNAME= @USERNAME ", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.label1.Text);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    label1.Text = "WELCOME "+dr[0].ToString().ToUpper();
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            write_ans wa = new write_ans(qs1);
            wa.Show();
            Hide();
        }
    }
}
