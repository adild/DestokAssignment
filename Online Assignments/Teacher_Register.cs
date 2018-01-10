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
    public partial class Teacher_Register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Adil\documents\visual studio 2010\Projects\Online Assignments\Online Assignments\OnlineAssDb .mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        public Teacher_Register()
        {
            InitializeComponent();
        }

        public void insertdata()
        {
            try
            {
                con.Open();
                string str = "insert into teacherReg values ('" + nametextBox.Text + "','" + usertextBox.Text + "','" + passtextBox.Text + "','" + RadioButtonText() + "')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception er) { MessageBox.Show(er.Message); }

            MessageBox.Show("data inserted succes");
            con.Close();
        }

        public int UserNameCheck()
        {
            SqlCommand cmd = new SqlCommand("Select * from teacherReg where USERNAME= @USERNAME", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.usertextBox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Username = " + dr[1].ToString() + " Already exist");
                    usertextBox.Text = " ";
                    con.Close();
                    return 1;
                    //break;
                }
            }
            con.Close();
            return 0;
        }

        public int passCheck()
        {

            if (string.IsNullOrEmpty(passtextBox.Text))
            {
                MessageBox.Show("Password required!");
                return 1;
            }

            return 0;
        }
        public int nullcheck()
        {
            if (nametextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to name textbox!");
                return 1;
            }
            else if (usertextBox.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please check one radio button!");
                return 1;
            }
            return 0;

        }

        private string RadioButtonText()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else
            {
                return radioButton2.Text;
            }
        }

        public void clearall()
        {
            nametextBox.Text = " ";
            usertextBox.Text = " ";
            passtextBox.Text = " ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nullcheck() == 0 && UserNameCheck() == 0 && passCheck() == 0)
            {
                insertdata();
                this.Hide();
                Teacher_Login tl = new Teacher_Login();
                tl.Show();
            }
        }

    }
}
