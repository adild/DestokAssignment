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
    public partial class make_questions : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Adil\documents\visual studio 2010\Projects\Online Assignments\Online Assignments\OnlineAssDb .mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;

        public make_questions()
        {
            InitializeComponent();
        }

        public int nullcheck()
        {
            if (textBox15.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to name textbox!");
                return 1;
            }
            else if (textBox14.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (textBox13.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (textBox12.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (textBox11.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            else if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Please select a value into username!");
                return 1;
            }
            
            return 0;

        }


        public void deletedata()
        {
            try
            {
                con.Open();
                string str = "delete from makeQuestions";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception er) { MessageBox.Show(er.Message); }

            //MessageBox.Show("data inserted succes");
            con.Close();

        }



        public void insertdata()
        {
            try
            {
                con.Open();
                string str = "insert into makeQuestions(CLASS,SEMISTER,SUBJECT,ASS#NO,DEADLINE,QUESTION#1,QUESTION#2,QUESTION#3,QUESTION#4,QUESTION#5,QUESTION#6,QUESTION#7,QUESTION#8,QUESTION#9,QUESTION#10) values ('" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + textBox12.Text + "','" + textBox11.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception er) { MessageBox.Show(er.Message); }

            //MessageBox.Show("data inserted succes");
            con.Close();
            
        }       


        public int AssignmentCheck()
        {
            if (Ass_Class_Check() == 1)
            {
                cmd = new SqlCommand("Select * from makeQuestions where ASS#NO= @ASS#NO and CLASS='" + textBox15.Text + "'", con);
                cmd.Parameters.AddWithValue("@ASS#NO", this.textBox12.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        MessageBox.Show("ASSIGNMENT NO FOR CLASS " + dr[0].ToString() + " Already exist");
                        //textBox12.Text = " ";
                        con.Close();
                        return 1;
                        //break;
                    }
                }
                con.Close();
            }
                return 0;
            
        }


        int Ass_Class_Check()
        { 
    
            cmd = new SqlCommand("Select * from makeQuestions where CLASS= @CLASS", con);

            cmd.Parameters.AddWithValue("@CLASS", this.textBox15.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("ASS#NO = " + dr[1].ToString() + " Already exist");
                    //textBox12.Text = " ";
                    con.Close();
                    return 1;
                    //break;
                }
            }
            con.Close();
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nullcheck() == 0 && AssignmentCheck() == 0)
            { 
                insertdata();
                MessageBox.Show("data inserted succes");
            }        
        }

        
        public void deletedata2()
        {
            try
            {
                con.Open();
                string str = "delete from makeQuestions";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception er) { MessageBox.Show(er.Message); }

            //MessageBox.Show("data inserted succes");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Login l = new Teacher_Login();
            l.Show();
            this.Hide();
        }
    }
}
