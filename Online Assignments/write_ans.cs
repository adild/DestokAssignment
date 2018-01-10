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
    public partial class write_ans : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Adil\documents\visual studio 2010\Projects\Online Assignments\Online Assignments\OnlineAssDb .mdf;Integrated Security=True;User Instance=True");
        String uname,answer;
        SqlCommand cmd;
        public write_ans(String usename12)
        {
            InitializeComponent();
            label2.Text = usename12;
            uname = usename12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answer = (sender as Button).Text;
            cmd = new SqlCommand("SELECT QUESTION#1 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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
            label3.Text = (sender as Button).Text;
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
            label3.Text = (sender as Button).Text;
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#3 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = (sender as Button).Text;
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#4 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = (sender as Button).Text;
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#5 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = (sender as Button).Text;
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#6 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = (sender as Button).Text;
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#7 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = (sender as Button).Text;
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#8 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = (sender as Button).Text;
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#9 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = (sender as Button).Text;
            SqlCommand cmd = new SqlCommand("SELECT QUESTION#10 FROM makeQuestions where CLASS='" + label2.Text + "' ORDER BY ASS#NO DESC", con);
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

        private void write_ans_Load(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            Student_Login sl = new Student_Login();
            sl.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "insert into writeAnswers (ANSWER#1,CLASS,UNAME) values ('" + richTextBox1.Text + "','" +label2.Text + "','" + uname + "')";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button1.Enabled = false;
                        button2.Enabled = true;
                        
                        submit2.Visible = true;
                        submit1.Visible = false;
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
        public int lenght_check()
        {
            String a = richTextBox1.Text;
            
            int len = 200;
            if (a.Length < len)
            {
                MessageBox.Show("the answer should be minimum 200 letters for question#1");
                return 1;
            }
            return 0;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#2 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button2.Enabled = false;
                        button3.Enabled = true;

                        submit3.Visible = true;
                        submit2.Visible = false;
            
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

        private void submit3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#3 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button3.Enabled = false;
                        button4.Enabled = true;

                        submit4.Visible = true;
                        submit3.Visible = false;
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

        private void submit4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#4 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button4.Enabled = false;
                        button5.Enabled = true;

                        submit5.Visible = true;
                        submit4.Visible = false;
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

        private void submit5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#5 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button5.Enabled = false;
                        button6.Enabled = true;

                        submit6.Visible = true;
                        submit5.Visible = false;
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

        private void submit6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#6 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button6.Enabled = false;
                        button7.Enabled = true;

                        submit7.Visible = true;
                        submit6.Visible = false;
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

        private void submit7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#7 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button7.Enabled = false;
                        button8.Enabled = true;

                        submit8.Visible = true;
                        submit7.Visible = false;
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

        private void submit8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#8 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button8.Enabled = false;
                        button9.Enabled = true;

                        submit9.Visible = true;
                        submit8.Visible = false;
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

        private void submit9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#9 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
                        cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted succes");
                        button9.Enabled = false;
                        button10.Enabled = true;

                        submit10.Visible = true;
                        submit9.Visible = false;
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

        private void submit10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (lenght_check() == 1)
                {

                }
                else
                {
                    try
                    {
                        con.Open();
                        string str = "update writeAnswers set ANSWER#10 = '" + richTextBox1.Text + "' where CLASS='" + label2.Text + "' AND UNAME='" + uname + "'";
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

        private void button11_Click_1(object sender, EventArgs e)
        {
            deletedata4();
        }
        
    }
}
