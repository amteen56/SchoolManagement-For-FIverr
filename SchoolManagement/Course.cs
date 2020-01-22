using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    [Serializable]
    public class Course
    {
        String coName;
        int coID;
        int students;
        int maxStu;
        List<Student> myStudents;
        List<Grade> myGrades;

        public Course(String coName, int coID, int students, int maxStu)
        {
            this.coName = coName;
            this.coID = coID;
            this.students = students;
            this.maxStu = maxStu;
            myStudents = new List<Student>();
            myGrades = new List<Grade>();
        }
        public void addGrade(Grade g)
        {
            myGrades.Add(g);

        }
        public Double getClassAverage()
        {

            Double avg;
            if (myGrades.Count > 0)
            {
                avg = 0.0;

                foreach (Grade grades in myGrades)
                {
                    avg += ((double)(grades.getGrade()));
                }

                if (avg == 0.0)
                {
                    return -1;
                }
                return avg / myGrades.Count;
            }



            else return -1;




        }




        public List<Grade> getMyGrades()
        {
            return myGrades;
        }

        public void setMyGrades(List<Grade> myGrades)
        {
            this.myGrades = myGrades;
        }

        public String getCoName()
        {
            return coName;
        }

        public void setCoName(String coName)
        {
            this.coName = coName;
        }

        public int getCoID()
        {
            return coID;
        }

        public void setCoID(int coID)
        {
            this.coID = coID;
        }

        public int getStudents()
        {
            return students;
        }

        public void setStudents(int students)
        {
            this.students = students;
        }

        public int getMaxStu()
        {
            return maxStu;
        }

        public void setMaxStu(int maxStu)
        {
            this.maxStu = maxStu;
        }
        public void addStu(Student s)
        {
            myStudents.Add(s);
            students++;
        }

        public void dropStu(Student s)
        {

            myStudents.Remove(myStudents.ElementAt(myStudents.IndexOf(s)));
            students--;
        }

        public List<Student> getMyStudents()
        {
            return myStudents;
        }

        public void setMyStudents(List<Student> myStudents)
        {
            this.myStudents = myStudents;
        }

        public int remSeats()
        {
            return (maxStu - students);
        }

       
     public String toString()
        {
            StringBuilder str = new StringBuilder();

            str.Append("\n");

            str.Append("Course Name= " + coName);
            str.Append("\n");

            str.Append("Course ID= " + coID);
            str.Append("\n");

            str.Append("Students= " + students);
            str.Append("\n");

            str.Append("Max Seats= " + maxStu);
            str.Append("\n");

            str.Append("Remaining Seats= " + remSeats());
            str.Append("\n");



            if (getClassAverage() == -1)
            {
                MessageBox.Show("No grades yet Assigned");
                str.Append("\n");
            }
            else
            {

                str.Append("Class Average " + getClassAverage());
                str.Append("\n");

            }

            str.Append("Registered Students: ");



            foreach (Student s in myStudents)
            {
                str.Append("Student ID= " + s.getIdNum() + " Student Name: " + s.getName() + ", ");

            }


            return str.ToString();
        }



    }
}
