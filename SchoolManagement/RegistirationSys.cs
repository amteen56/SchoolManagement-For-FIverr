using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SchoolManagement
{
    public class RegistrationSys
    {
        public List<Student> kids = new List<Student>();
        public List<Course> classes = new List<Course>();
        public List<Grade> Grades = new List<Grade>();
        public String schoolDat;




        public RegistrationSys(string schoolDat, List<Student> kids, List<Course> classes, List<Grade> grade)
        {

            this.kids = kids;
            this.classes = classes;
            this.Grades = grade;
            this.schoolDat = schoolDat;

        }

        public void createGrade(int SID, int CID, int Grade)
        {

            if (getStudentByID(SID) != null)
            {
                Grade g = new Grade(SID, CID, Grade);
                this.Grades.Add(g);
                getCourseByID(CID).addGrade(g);
                getStudentByID(SID).addGrade(g);

            }
            else
            {
                MessageBox.Show("This Action was not Performed becuase you entered an Invalid SID");
            }


        }


        public string printClassAverage(int CID)
        {
            if ((getCourseByID(CID).getClassAverage()) == -1)
            {
                return "No grades yet Assigned";
            }
            else
            {
                return "Class Average: " + getCourseByID(CID).getClassAverage();

            }

        }

        public string printStudentAverage(int SID)
        {
            if (getStudentByID(SID).getGPA() == -1)
            {
                MessageBox.Show("No grades yet Assigned");
                return "";
            }
            else
            {
                return "GPA: " + getStudentByID(SID).getGPA();
            }

        }





        public void signStudent(int SID, int CID)
        {
            Student s = this.getStudentByID(SID);
            Course c = this.getCourseByID(CID);

            if (s == null || c == null)
            {
                MessageBox.Show("ERROR: SID Or CID DNE");
            }
            else
            {

                s.addClass(c);
                c.addStu(s);

            }

        }

        public void dropStudent(int SID, int CID)
        {
            Student s = this.getStudentByID(SID);
            Course c = this.getCourseByID(CID);

            if (s == null || c == null)
            {
                MessageBox.Show("ERROR: SID Or CID DNE");
            }
            else
            {
                s.dropClass(c);
                c.dropStu(s);

            }

        }

        public Course getCourseByID(int idNum)
        {
            foreach (Course co in classes)
            {
                if (co.getCoID() == idNum)
                {
                    return co;
                }
            }
            return null;

        }

        public Student getStudentByID(int idNum)
        {
            foreach (Student stu in kids)
            {
                if (stu.getIdNum() == idNum)
                {
                    return stu;
                }
            }
            return null;

        }
        public void createCourse(String coName, int coID, int students, int maxStu)
        {
            Course nClass = new Course(coName, coID, students, maxStu);
            this.addClass(nClass);
        }

        public void remCourse(int CID)
        {
            Course c = this.getCourseByID(CID);
            foreach (Student s in c.getMyStudents())
            {
                s.dropClass(c);
            }
            classes.Remove(c);
        }

        public void remStudent(int SID)
        {
            Student s = this.getStudentByID(SID);
            foreach (Course c in s.getMycourses())
            {
                c.dropStu(s);
            }
            kids.Remove(s);
        }

        public void addClass(Course c)
        {
            classes.Add(c);

        }

        public void createStudent(String name, int idNum)
        {
            Student nKid = new Student(name, idNum);
            this.addStudent(nKid);
        }

        public void addStudent(Student s)
        {
            kids.Add(s);
        }

        public string getAllStudents()
        {
            string msg = "";
            foreach (Student s in kids)
            {
                msg+=s.toString()+"\n";
            }
            return msg;
        }

        public string getAllCourses()
        {
            string msg = "";
            foreach (Course c in classes)
            {
                msg+=c.toString() + "\n";
            }
            return msg;
        }

        public string printAllGrades()
        {
            string msg = "";
            foreach (Grade g in Grades)
            {
                msg+=g.toString() + "\n";
            }

            return msg;
        }
        public string printAllGradesBySID(int SID)
        {
            string msg = "";
            foreach (Grade g in getStudentByID(SID).getMyGrades())
            {
                msg+=g.toString()+"\n";
            }
            return msg;
        }

        public string printAllGradesByCID(int CID)
        {
            string msg = "";
            foreach (Grade g in getCourseByID(CID).getMyGrades())
            {
                msg+=g.toString()+"\n";
            }
            return msg;
        }
        public void get()
        {
            try
            {
                using (Stream stream = File.Open("Grades.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    Grades = (List<Grade>) bformatter.Deserialize(stream);
                }
            }
            catch (IOException ioe)
            {
                return;
            }


            try
            {
                using (Stream stream = File.Open("Student.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    kids = (List<Student>)bformatter.Deserialize(stream);
                }
            }
            catch (IOException ioe)
            {
                return;
            }
            catch (Exception c)
            {
                MessageBox.Show("Class not found");
                return;
            }

            try
            {
                using (Stream stream = File.Open("Course.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    classes = (List<Course>)bformatter.Deserialize(stream);
                }
            }
            catch (IOException ioe)
            {
                return;
            }
            catch (Exception c)
            {
                return;
            }
         
        }
        public void save()
        {
            try
            {
                string serializationFile = Path.Combine("","Student.bin");

                //serialize
                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, kids);
                }
            }
            catch (Exception ioe)
            {
            }
            try
            {
                string serializationFile = Path.Combine("", "Course.bin");

                //serialize
                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, classes);
                }
            }
            catch (IOException ioe)
            {
                
            }
            try
            {
                string serializationFile = Path.Combine("", "Grades.bin");

                //serialize
                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, Grades);
                }
            }
            catch (IOException ioe)
            {
            }
        }

    }

}
