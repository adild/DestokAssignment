using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Online_Assignments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Student_Reg_Click(object sender, EventArgs e)
        {
            Student_Register stud = new Student_Register();
            stud.Show();
            Hide();
        }

        private void Teacher_Reg_Click(object sender, EventArgs e)
        {
            Teacher_Register teach = new Teacher_Register();
            teach.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Login stud = new Student_Login();
            stud.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Login stud = new Teacher_Login();
            stud.Show();
            Hide();
        }
    }
}
