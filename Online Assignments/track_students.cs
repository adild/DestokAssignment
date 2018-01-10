using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data.SqlServerCe;

namespace Online_Assignments
{
    public partial class track_students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Adil\documents\visual studio 2010\Projects\Online Assignments\Online Assignments\OnlineAssDb .mdf;Integrated Security=True;User Instance=True");

        public track_students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            // 2
            // Create new DataAdapter
            using (SqlDataAdapter a = new SqlDataAdapter(
                "SELECT w.UNAME FROM writeAnswers w , makeQuestions m where w.CLASS=m.CLASS and w.CLASS='"+comboBox1.Text+"' and m.ASS#NO='"+comboBox2.Text+"'", con))
            {
                // 3
                // Use DataAdapter to fill DataTable
                DataTable t = new DataTable();
                try
                {
                    a.Fill(t);
                }
                catch (Exception)
                {
                    MessageBox.Show("please select values");
                }
                // 4
                // Render data onto the screen
                dataGridView1.DataSource = t;
                con.Close();
            }
        }

        private void track_students_Load(object sender, EventArgs e)
        {

        }
    }
}
