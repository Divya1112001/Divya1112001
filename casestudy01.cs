using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy01
{
class student    {        public int stdid { get; set; }        public string stdname { get; set; }        public DateTime dob { get; set; }                public student(int stdid, string stdname, DateTime dob)        {            this.stdid = stdid;            this.stdname = stdname;            this.dob = dob;        }    }

class Course    {        public int CId { get; set; }        public string CName { get; set; }        public string Duration { get; set; }        public double Fees { get; set; }        public Course(int courseid, string cname, string coursedur, double coursefee)        {            CId = courseid;            CName = cname;            Duration = coursedur;            Fees = coursefee;        }    }

class LocalDate    {        public DateTime Enrollmentdate { get; set; }        public LocalDate(DateTime enrollmentdate)        {            Enrollmentdate = enrollmentdate;        }    }


class Info    {        public void Display(student student)        {            Console.WriteLine("Studnetid: " + student.stdid + '\n'+ "Name :" + student.stdname + '\n'+ "DateofBirth: " + student.dob);            Console.ReadLine();        }        public void Display1(Course course)        {            Console.WriteLine("CourseId :" + course.CId + '\n' + "CourseName: " + course.CName + '\n' + "CourseDuration: " + course.Duration + '\n' + "Course Fee" + course.Fees);            Console.ReadLine();        }        //public void Display2(Enroll enroll)        //{        //    Console.WriteLine("studentname :" + enroll.students + '\n' + " coursename :" + enroll.courses + '\n' + "EnrollmentDate : " + enroll.EnrollmentDate);        //    Console.ReadLine();        //}    }


class Enroll    {        private student student;        private Course course;        private LocalDate enrollmentDate;        public string students        {           get { return students;}           set {  students = value;}         }        public string courses        {            get { return courses; }            set { courses = value; }        }        public string enrollmentDates        {            get { return enrollmentDates; }            set { enrollmentDates = value; }        }        public Enroll (string studentname, string coursename, LocalData EnrollmentDate)        {            students = studentname;            courses = coursename;          //  EnrollmentDate = EnrollmentDate;           }    }

class App : Info    {        //Scenario-1        public void Scenario1()        {            student st = new student(001, "Tejaswi", Convert.ToDateTime("02-01-2000"));            Course c = new Course(1, "Csharp", "6 Months", 20000);            Console.WriteLine("Student data");            Display(st);            Console.WriteLine("Course info");            Display1(c);        }        //Scenario-2        public void Scenario2()        {

            student[] std = new student[3];            std[0] = new student(101, "Divya", Convert.ToDateTime("10-07-1999"));            std[1] = new student(102, "Haritha", Convert.ToDateTime("12-08-1998"));            std[2] = new student(103, "manasa", Convert.ToDateTime("9-09-1999"));            Console.WriteLine("Student information:");            for (int i = 0; i < 3; ++i)            {                Display(std[i]);            }            Course[] cour = new Course[3];            cour[0] = new Course(1, "java", "10 months", 40000);            cour[1] = new Course(2, "SQL", "1 MONTH", 20000);            cour[2] = new Course(3, "ADO.NET", "3 months", 30000);            Console.WriteLine("Course Information:");            for (int i = 0; i < 3; ++i)            {                Display1(cour[i]);            }        }        //Scenario-3        public void Scenario3()        {            for (int i = 0; i < 3; i++)            {                Console.WriteLine("Enter student id,name, DOB :");                int id = Convert.ToInt32(Console.ReadLine());                string name = Console.ReadLine();                DateTime dob = Convert.ToDateTime(Console.ReadLine());


                Console.WriteLine("enter the course id,Name,duration,fees");                int Cid = Convert.ToInt32(Console.ReadLine());                string cname = Console.ReadLine();                string cdur = Console.ReadLine();                double Cfee = Convert.ToDouble(Console.ReadLine());


                student[] st = new student[3];                st[i] = new student(id, name, Convert.ToDateTime(dob));                Course[] c = new Course[3];                c[i] = new Course(Cid, cname, cdur, Cfee);                Console.WriteLine("Student information:");                Display(st[i]);                Console.WriteLine("Course Information:");                Display1(c[i]);            }

        }

    }    class Program    {        static void Main(string[] args)        {            App a = new App();            // a.Scenario1();            //  a.Scenario2();            // a.Scenario3();

            AppEngine A = new AppEngine();            //A.introduce();            A.listOfStudents();            //A.listofstudent();            //A.listofcourse();            //A.eroll(obj, s);        }    }


class AppEngine : Info    {        student[] std1 = new student[1];        student[] student;        Course[] course;        Enroll[] enroll;        public void introduce(Course course)        {

        }

        public void register(student student)        {            student[] std1 = new student[1];            std1[0] = new student(321, "manasa", Convert.ToDateTime("21/01/2000"));            Display(std1[0]);        }        public student[] listOfStudents()        {            Console.WriteLine("list of students");            App a = new App();            a.Scenario1();            a.Scenario2();            AppEngine a1 = new AppEngine();            a1.register(std1[0]);            return std1;        }    }
}
