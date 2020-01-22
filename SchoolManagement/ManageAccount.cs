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
    public partial class ManageAccount : Form
    {
        List<Student> kids = new List<Student>();
        List<Course> classes = new List<Course>();
        List<Grade> grades = new List<Grade>();
        string school = "PITT";
        RegistrationSys pitt;
       
        public ManageAccount()
        {
            InitializeComponent();
            pitt = new RegistrationSys(school, kids, classes, grades);
            pitt.get();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = pitt.getStudentByID(int.Parse(nametext.Text));
            if (a == null)//||(((pitt.getCourseByID(courseID)).myStudents).contains(pitt.getStudentByID(studenID)))==false)
            {
                MessageBox.Show("Student not Found...");
            }
            else
            {
                bunifuMaterialTextbox1.Text = a.getName();
                bunifuMaterialTextbox2.Text = a.getCourseCount().ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pitt.getCourseByID(int.Parse(nametext.Text)) == null)
            {
                MessageBox.Show("This Action was not Perfromed because The Course ID You entered Did Not Exist...");
            }
            pitt.signStudent(int.Parse(nametext.Text), int.Parse(bunifuMaterialTextbox5.Text));
            MessageBox.Show("Student is Succesfully Added");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pitt.getCourseByID(int.Parse(bunifuMaterialTextbox5.Text)) == null)
            {
                MessageBox.Show("This Action was not Perfromed because The Course ID You entered Did Not Exist...");
            }
            pitt.dropStudent(int.Parse(nametext.Text), int.Parse(bunifuMaterialTextbox5.Text));
            MessageBox.Show("Student is Succesfully Dropped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pitt.remStudent(int.Parse(nametext.Text));
            MessageBox.Show("Student is Removed");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = pitt.printAllGradesBySID(int.Parse(nametext.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = pitt.printStudentAverage(int.Parse(nametext.Text));
        }
    }
}
