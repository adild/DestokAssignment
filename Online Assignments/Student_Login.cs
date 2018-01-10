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
    public partial class Student_Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Adil\documents\visual studio 2010\Projects\Online Assignments\Online Assignments\OnlineAssDb .mdf;Integrated Security=True;User Instance=True");

        public Student_Login()
        {
            InitializeComponent();
        }

        public int Login()
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                SqlCommand cmd = new SqlCommand("Select * from studentReg where USERNAME= @USERNAME and Password = @Password", con);
                cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", this.textBox2.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        //MessageBox.Show("login success");
                        return 1;
                    }
                }
                if (dr.HasRows == false)
                {
                    MessageBox.Show("access denied");
                }
                else
                {
                    MessageBox.Show("Enter username and password");
                }
            }
            con.Close();
            return 0;
        }

        private void Student_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login() == 1)
            {
                Student_home st = new Student_home(textBox1.Text);
                st.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

    }
}

