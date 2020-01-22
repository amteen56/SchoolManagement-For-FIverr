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
    public partial class ManageCourse : Form
    {
        List<Student> kids = new List<Student>();
        List<Course> classes = new List<Course>();
        List<Grade> grades = new List<Grade>();
        string school = "PITT";
        RegistrationSys pitt;

        public ManageCourse()
        {
            InitializeComponent();
            pitt = new RegistrationSys(school, kids, classes, grades);
            pitt.get();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = pitt.getCourseByID(int.Parse(nametext.Text));
            if (a == null)//||(((pitt.getCourseByID(courseID)).myStudents).contains(pitt.getStudentByID(studenID)))==false)
            {
                MessageBox.Show("Course not Found...");
            }
            else
            {
                bunifuMaterialTextbox1.Text = a.getCoName();
                bunifuMaterialTextbox2.Text = a.getMaxStu().ToString();
                bunifuMaterialTextbox5.Text = a.remSeats().ToString();
                bunifuMaterialTextbox4.Text = a.getClassAverage().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pitt.getStudentByID(int.Parse(bunifuMaterialTextbox6.Text)) == null)
            {
                MessageBox.Show("This Action was not Perfromed because The Course ID You entered Did Not Exist...");
            }
            else
            {
                pitt.signStudent(int.Parse(bunifuMaterialTextbox6.Text), int.Parse(nametext.Text));
                MessageBox.Show("Student is Succesfully Added");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pitt.getStudentByID(int.Parse(bunifuMaterialTextbox6.Text)) == null)
            {
                MessageBox.Show("This Action was not Perfromed because The Course ID You entered Did Not Exist...");
            }
            else

            {
                pitt.dropStudent(int.Parse(bunifuMaterialTextbox6.Text), int.Parse(nametext.Text));
                MessageBox.Show("Student is Succesfully Dropped");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pitt.remCourse(int.Parse(nametext.Text));
            MessageBox.Show("Course is Removed");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pitt.getStudentByID(int.Parse(bunifuMaterialTextbox6.Text)) == null)
            {
                MessageBox.Show("This Action was not Perfromed because The Course ID You entered Did Not Exist...");
            }
            else
            {
                if (int.Parse(bunifuMaterialTextbox3.Text) < 0 || int.Parse(bunifuMaterialTextbox6.Text) > 100)
                {
                    MessageBox.Show("This Action was not Perfromed because You Entered an Invalid Grade expected range = [0,100]...");
                }
                else
                {
                    pitt.createGrade(int.Parse(bunifuMaterialTextbox6.Text), int.Parse(nametext.Text), int.Parse(bunifuMaterialTextbox3.Text));
                    pitt.dropStudent(int.Parse(bunifuMaterialTextbox6.Text), int.Parse(nametext.Text));
                    MessageBox.Show("Grade Asigned!");
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= pitt.printAllGradesByCID(int.Parse(nametext.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = pitt.printClassAverage(int.Parse(nametext.Text));
        }
    }
}
