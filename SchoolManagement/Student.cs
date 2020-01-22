using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    [Serializable]
    public class Student
    {
        String name;
        int idNum;
        List<Course> mycourses;
        List<Grade> myGrades;

        public Student(String name, int idNum)
        {
            this.name = name;
            this.idNum = idNum;
            mycourses = new List<Course>();
            myGrades = new List<Grade>();

        }
        public void addGrade(Grade g)
        {
            myGrades.Add(g);

        }
        public Double getGPA()
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

        public void addClass(Course c)
        {

            mycourses.Add(c);
        }

        public void dropClass(Course c)
        {

            mycourses.Remove(mycourses.ElementAt(mycourses.IndexOf(c)));
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getIdNum()
        {
            return idNum;
        }

        public int getCourseCount()
        {
            return mycourses.Count;
        }

        public void setIdNum(int idNum)
        {
            this.idNum = idNum;
        }

        public List<Course> getMycourses()
        {
            return mycourses;
        }

        public void setMycourses(List<Course> mycourses)
        {
            this.mycourses = mycourses;
        }

        public String toString()
        {
            StringBuilder str = new StringBuilder();

            str.Append("\n");

            str.Append("Student Name= " + name);
            str.Append("\n");

            str.Append("Student ID= " + idNum);
            str.Append("\n");

            str.Append("Courses Count= " + getCourseCount());
            str.Append("\n");

            if (getGPA() == -1)
            {
                str.Append("\n");
            }
            else
            {

                str.Append("GPA: " + getGPA());
                str.Append("\n");

            }



            foreach (Course c in mycourses)
            {
                str.Append("Course ID= " + c.getCoID() + " Course Name= " + c.getCoName() + ", ");

            }


            return str.ToString();
        }
    }
}
