using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study
{
    class student
    {
        public int stdid { get; set; }
        public string stdname { get; set; }
        public float marks { get; set; }
        student[] s = new student[3];

        public student[] Display()
        {
            student[] sres = new student[3];
            for (int i = 0; i < s.Length; i++)
            {
                sres[i] = new student()
                {
                    stdid = s[i].stdid,
                    stdname = s[i].stdname,
                    marks = s[i].marks,
                };
            }
            return sres;
        }
        public void accept_student()
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter Stdid, Stdname,Stdmarks");
                int id = Convert.ToInt32(Console.ReadLine());
                string nm = Console.ReadLine();
                float mks = float.Parse(Console.ReadLine());
                s[i] = new student()
                {
                    stdid = id,
                    stdname = nm,
                    marks = mks,
                };
            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            student[] stdlist = new student[3];

            std.accept_student();
            stdlist = std.Display();
            for (int i = 0; i < stdlist.Length; i++)
            {
                Console.WriteLine(stdlist[i].stdid+" " + stdlist[i].stdname+" " + stdlist[i].marks);
            }
            Console.Read();
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study
{
    class course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }

        course[] c = new course[3];

        public course[] Display()
        {
            course[] cour = new course[3];
            for (int i = 0; i < c.Length; i++)
            {
                cour[i] = new course()
                {
                    CId = c[i].CId,
                    CName = c[i].CName,
                    Duration = c[i].Duration,
                    Fees = c[i].Fees
                };
            }
            return cour;
        }
        public void accept_course()
        {
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Enter courseid,Name,duration,fees");
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                string dur = Console.ReadLine();
                double fee = Convert.ToDouble(Console.ReadLine());
                c[i] = new course()
                {
                    CId = id,
                    CName = name,
                    Duration = dur,
                    Fees = fee
                };
            }
        }

    }
    class Program1
    {
        static void Main(string[] args)
        {
            course cos= new course();
            course[] coslist = new course[3];

            cos.accept_course();
            coslist = cos.Display();
            for (int i = 0; i < coslist.Length; i++)
            {
                Console.WriteLine(coslist[i].CId+" " + coslist[i].CName+" " + coslist[i].Duration+" " + coslist[i].Fees);
            }
            Console.Read();
        }
    }
}

