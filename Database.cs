using System;
using System.Data;
using System.Data.SqlClient;

namespace case_study
{
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
