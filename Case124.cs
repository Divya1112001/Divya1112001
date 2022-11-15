using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace case_study
{
  class student 
     { 
        public int stdid { get; set; } 
        public string stdname { get; set; } 
        public DateTime dob { get; set; } 
        public student(int stdid, string stdname, DateTime dob)
         {
            this.stdid = stdid;
            this.stdname = stdname;
            this.dob = dob;
          }
        }
        
  class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }
        public Course(int courseid, string cname, string coursedur, double coursefee)
        {
            CId = courseid;
            CName = cname;
            Duration = coursedur;
            Fees = coursefee;
        }
    }
    
    class Enroll
    {
        private student student;
        private Course course;
        private LocalDate enrollmentDate;
        public string students
        {
            get { return students; }
            set { students = value; }
        }
        public string courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public string enrollmentDates
        {
            get { return enrollmentDates; }
            set { enrollmentDates = value; }
        }
        public Enroll(string studentname, string coursename, LocalDate EnrollmentDate)
        {
            students = studentname;
            courses = coursename;
            //  EnrollmentDate = EnrollmentDate;       
        }
    }
    
     class LocalDate 
    {
        public DateTime Enrollmentdate { get; set; } 
        public LocalDate(DateTime enrollmentdate)
        {
            Enrollmentdate = enrollmentdate; 
        }
    }
    
    class Info
    {
        public void Display(student student) 
        {
            Console.WriteLine("Studnetid: " + student.stdid + '\n' + "Name :" + student.stdname + '\n' + "DateofBirth: " + student.dob); 
           
        }
        public void Display1(Course course) 
        {
            Console.WriteLine("CourseId :" + course.CId + '\n' + "CourseName: " + course.CName + '\n' + "CourseDuration: " + course.Duration + '\n' + "Course Fee" + course.Fees);
            Console.ReadLine(); 
        }        
        //public void Display2(Enroll enroll)     
        //{    
        //    Console.WriteLine("studentname :" + enroll.students + '\n' + " coursename :" + enroll.courses + '\n' + "EnrollmentDate : " + enroll.EnrollmentDate);      
        //    Console.ReadLine();
        //    }
    }
    
    class AppEngine : Info
    {
        student[] std1 = new student[1]; 
        student[] student; 
        Course[] course; 
        Enroll[] enroll; 
        public void introduce(Course course)
        {

        }

        public void register(student student)
        {
            student[] std1 = new student[1];
            std1[0] = new student(5, "manasa", Convert.ToDateTime("21/01/2000"));
            Display(std1[0]); 
        }
        public student[] listOfStudents() 
        {
           
            App a = new App();
            a.Scenario1(true,false); 
            a.Scenario2(true, false);
            a.Scenario3(true, false);
            Console.WriteLine("list of students");
            var std = a.studArray;
            for (int i = 0; i < 10; ++i)
            {
                if(std[i]!=null)
                a.Display(std[i]);
            }
            Console.ReadLine();
            AppEngine a1 = new AppEngine();
            a1.register(std1[0]);
            return std1; 
          }
       }
       
        class App : Info
    {
       public student[] studArray = new student[10];


        //Scenario-1sssss
        public void Scenario1(bool student,bool course)
        {
            if (student)
            {
                student st = new student(1, "Tejaswi", Convert.ToDateTime("02-01-2000"));
                studArray[0] = st;
                Console.WriteLine("Student data");
              //  Display(st);
            }
            if (course)
            {
                Course c = new Course(1, "Csharp", "6 Months", 20000);
                Console.WriteLine("Course info");
                Display1(c);
            }
            
        }

        // Scenario-2
        public void Scenario2(bool student, bool course)
        {
            if (student)
            {
                student[] std = new student[3];
                std[0] = new student(2, "Divya", Convert.ToDateTime("10-07-1999"));
                studArray[1] = std[0];
                std[1] = new student(3, "Haritha", Convert.ToDateTime("12-08-1998"));
                studArray[2] = std[1];
                std[2] = new student(4, "manasa", Convert.ToDateTime("9-09-1999"));
                studArray[3] = std[2];
                Console.WriteLine("Student information:");
                //for (int i = 0; i < 3; ++i)
                //{
                //    Display(std[i]);
                //}
            }
            if (course)
            {
                Course[] cour = new Course[3];
                cour[0] = new Course(2, "java", "10 months", 40000);
                cour[1] = new Course(3, "SQL", "1 MONTH", 20000);
                cour[2] = new Course(4, "ADO.NET", "3 months", 30000);
                Console.WriteLine("Course Information:");
                //for (int i = 0; i < 3; ++i)
                //{
                //    Display1(cour[i]);
                //}
            }
        }
        //Scenario-3
        public void Scenario3(bool student, bool course)
        {
            int j = 3;
            for (int i = 0; i < 3; i++)
            {
                if (student)
                {
                    j = j + 1;
                    Console.WriteLine("Enter student id,name, DOB :");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    student[] st = new student[3];
                    st[i] = new student(id, name, Convert.ToDateTime(dob));
                    studArray[j] = st[i];
                    Console.WriteLine("Student information:");
                   // Display(st[i]);
                }
                if (course)
                {
                    Console.WriteLine("enter the course id,Name,duration,fees");
                    int Cid = Convert.ToInt32(Console.ReadLine());
                    string cname = Console.ReadLine();
                    string cdur = Console.ReadLine();
                    double Cfee = Convert.ToDouble(Console.ReadLine());
                    Course[] c = new Course[3];
                    c[i] = new Course(Cid, cname, cdur, Cfee);
                    Console.WriteLine("Course Information:");
                    Display1(c[i]);
                }
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            App a = new App();
            // a.Scenario1();   
            //  a.Scenario2();      
            // a.Scenario3();

            AppEngine A = new AppEngine();
            //A.introduce();
            A.listOfStudents();       
            //A.listofstudent();       
            //A.listofcourse();       
            //A.eroll(obj, s);
            //}
            //}

        }
    }
    
    class Databasecs
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=LAPTOP-PULFH92A;initial catalog=DotnetDB;" +
                "Integrated Security=True;Trusted_Connection=True");
            con.Open();
            return con;
        }

        public static void register()
        {
            try
            {
                con = getConnection();
                {

                    Console.WriteLine("Enter student id,name, DOB :");
                    int stdid = Convert.ToInt32(Console.ReadLine());
                    string stdname = Console.ReadLine();
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());

                    cmd = new SqlCommand("INSERT INTO student (stdid ,stdname,dob) VALUES (@stdid,@stdname,@dob)", con);
                    cmd.Parameters.AddWithValue("@stdid", stdid);
                    cmd.Parameters.AddWithValue("@stdname", stdname);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void introduce()
        {
            try
            {
                con = getConnection();
                {

                    Console.WriteLine("enter the course id,Name,duration,fees");
                    int Cid = Convert.ToInt32(Console.ReadLine());
                    string cname = Console.ReadLine();
                    string cdur = Console.ReadLine();
                    double Cfee = Convert.ToDouble(Console.ReadLine());

                    cmd = new SqlCommand("INSERT INTO Course(Cid ,cname,cdur,Cfee) VALUES (@Cid,@cname,@cdur,@Cfee)", con);
                    cmd.Parameters.AddWithValue("@Cid", Cid);
                    cmd.Parameters.AddWithValue("@cname", cname);
                    cmd.Parameters.AddWithValue("@cdur", cdur);
                    cmd.Parameters.AddWithValue("@Cfee", Cfee);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3] + " " + dr[4]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main(string[] args)
        {
            register();
            introduce();

            Console.ReadKey();
        }
    }
 }
  
