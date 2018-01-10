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
    public partial class write_answers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Adil\documents\visual studio 2010\Projects\Online Assignments\Online Assignments\OnlineAssDb .mdf;Integrated Security=True;User Instance=True");
        String uname;
        SqlCommand cmd;
        public write_answers(String usename12)
        {
            InitializeComponent();
            label2.Text = usename12;
            uname = usename12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT QUESTION#1 FROM makeQuestions where CLASS='"+label2.Text+"' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);
            //cmd.Parameters.AddWithValue("@PASSWORD", this.textBox2.Text);          
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
               
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        //MessageBox.Show("success");
                        String abc = dr[0].ToString();
                        textBox1.Text = abc;
                       
                        break;
                    }
                }
                if (dr.HasRows == false)
                {
                    MessageBox.Show("denied");
                }        
                 
            
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT QUESTION#2 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);
            try
            {
                con.Open();
            }
            catch (Exception er) { MessageBox.Show(er.Message); }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                    
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT QUESTION#3 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                    
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#4 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#5 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                    
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#6 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                  
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#7 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                    
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#8 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                    
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#9 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                   
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#10 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.textBox1.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("success");
                    String abc = dr[0].ToString();
                    textBox1.Text = abc;
                   
                    break;
                }
            }
            if (dr.HasRows == false)
            {
                MessageBox.Show("denied");
            }

            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (lenght_check()==1)
                {
                   
                }
                else
                {                    
                        try
                        {
                            con.Open();
                            string str = "insert into writeAnswers (ANSWER#1,ANSWER#2,ANSWER#3,ANSWER#4,ANSWER#5,ANSWER#6,ANSWER#7,ANSWER#8,ANSWER#9,ANSWER#10,CLASS,UNAME) values ('" + richTextBox1 + "','" + richTextBox2 + "','" + richTextBox3 + "','" + richTextBox4 + "','" + richTextBox5 + "','" + richTextBox6 + "','" + richTextBox7 + "','" + richTextBox8 + "','" + richTextBox9 + "','" + richTextBox10 + "','" + label2.Text + "','"+uname+"')";
                            cmd = new SqlCommand(str, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data inserted succes");
                        }
                        catch (Exception er) { MessageBox.Show(er.Message); }

                        //MessageBox.Show("data inserted succes");
                        con.Close();                
                }
            }
            else
            {
                MessageBox.Show("please select one the questions");
            }
        }

      
        private void write_answers_Load(object sender, EventArgs e)
        {
            this.Size = MaximumSize;
            SqlCommand cmd = new SqlCommand("Select CLASS from studentReg where USERNAME=@USERNAME", con);
            cmd.Parameters.AddWithValue("@USERNAME", this.label2.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    label2.Text = dr[0].ToString().ToUpper();
                }
            }
            con.Close();
        }

       
        public void deletedata4()
        {

            try
            {
                con.Open();
                string str = "delete from writeAnswers";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception er) { MessageBox.Show(er.Message); }

            //MessageBox.Show("data inserted succes");
            con.Close();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            Student_Login sl = new Student_Login();
            sl.Show();
            this.Hide();

        }

        public int lenght_check()
        {
            String a = richTextBox1.Text;
            String b = richTextBox2.Text;
            String c = richTextBox3.Text;
            String d = richTextBox4.Text;
            String e1 = richTextBox5.Text;
            String f = richTextBox6.Text;
            String g = richTextBox7.Text;
            String h = richTextBox8.Text;
            String i = richTextBox9.Text;
            String j = richTextBox10.Text;
            int len = 200;
            if (a.Length < len) 
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#1");
                return 1;
            }
            if(b.Length < len)
            {

                MessageBox.Show("the answer should be minimum 200 letters for question#2");
                return 1;
            }
            if(c.Length < len)
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#3");
                return 1;
            }
            if(d.Length < len)
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#4");
             
                return 1;
            }
            if(e1.Length < len)
            {

                MessageBox.Show("the answer should be minimum 200 letters for question#5");
             
                return 1;
            }
            if (f.Length < len)
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#6");
             
                return 1;
            }
            if (g.Length < len)
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#7");
             
                return 1;
            }
            if (h.Length < len)
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#8");
             
                return 1;
            }
            if (i.Length < len)
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#9");
             
                return 1;
            }
            if (j.Length < len)
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#10");
             
                return 1;
            }
            
            return 0;
        }

 }
} 
     

