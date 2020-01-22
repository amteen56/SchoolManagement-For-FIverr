using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Reports : Form
    {
        List<Student> kids = new List<Student>();
        List<Course> classes = new List<Course>();
        List<Grade> grades = new List<Grade>();
        string school = "PITT";
        RegistrationSys pitt;

        public Reports()
        {
            InitializeComponent();
            pitt = new RegistrationSys(school, kids, classes, grades);
            pitt.get();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= pitt.getAllCourses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = pitt.getAllStudents();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = pitt.printAllGrades();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
