using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    [Serializable]
    public class Grade
    {
        int studentID;
        int courseID;
        int grade;

        public Grade(int studentID, int courseID, int grade)
        {
            this.studentID = studentID;
            this.courseID = courseID;
            this.grade = grade;
        }

        public int getStudentID()
        {
            return studentID;
        }


        public void setStudentID(int studentID)
        {
            this.studentID = studentID;
        }

        public int getCourseID()
        {
            return courseID;
        }

        public void setCourseID(int courseID)
        {
            this.courseID = courseID;
        }

        public int getGrade()
        {
            return grade;
        }

        public void setGrade(int grade)
        {
            this.grade = grade;
        }

        public String toString()
        {
            return "Grade studentID=" + studentID + ", courseID=" + courseID + ", grade=" + grade;
        }
    }
}
