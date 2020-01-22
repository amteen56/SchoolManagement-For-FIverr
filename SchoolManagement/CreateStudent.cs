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
    public partial class CreateStudent : Form
    {
        List<Student> kids = new List<Student>();
        List<Course> classes = new List<Course>();
        List<Grade> grades = new List<Grade>();
        string school = "PITT";
        RegistrationSys pitt;
        public CreateStudent()
        {
            InitializeComponent();
            pitt = new RegistrationSys(school, kids, classes, grades);
            pitt.get();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            pitt.createStudent(nametext.Text, int.Parse(idtext.Text));
            MessageBox.Show("Student Created");
            pitt.save();
        }
    }
}
