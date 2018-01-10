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
    public partial class Teacher_home : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Adil\documents\visual studio 2010\Projects\Online Assignments\Online Assignments\OnlineAssDb .mdf;Integrated Security=True;User Instance=True");

        public Teacher_home(String ss)
        {
            InitializeComponent();
            label1.Text = ss;
        }

        private void Teacher_home_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select NAME from teacherReg where USERNAME= @USERNAME ", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.label1.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    label1.Text = "WELCOME " + dr[0].ToString().ToUpper();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            make_questions mk = new make_questions();
            mk.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            track_students ts = new track_students();
            ts.Show();
            this.Hide();
        }
    }
}
