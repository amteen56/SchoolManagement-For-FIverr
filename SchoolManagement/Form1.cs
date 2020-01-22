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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateStudent obj = new CreateStudent();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCourse obj = new CreateCourse();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageAccount obj = new ManageAccount();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageCourse obj = new ManageCourse();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports obj = new Reports();
            obj.ShowDialog();
        }
    }
}
