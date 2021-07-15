using System;

namespace Moduel3_Lab03
{
    class Program
    {
        static void GetStudentInfomation()
        {
            Console.WriteLine("Enrter the student first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enrter the student last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enrter the student birthday:");
            string birthday = Console.ReadLine();
        }
        static void PrintStudentDetails(string first, string last, string brithday)
        {
            Console.WriteLine("{0} {1} was bron on: {2}", first, last, brithday);
        }
        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enrter the teacher last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enrter the student email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enrter the student birthday:");
            string birthday = Console.ReadLine();
        }
        static void PrintTeacherDetails(string first, string last, string email,string brithday)
        {
            Console.WriteLine("{0} -- {1} -- {2} -- {3} ", first, last,email, brithday);
        }
        static void GetCourseInformation()
        {
            Console.WriteLine("Enter Id Course:");
            int idcourse = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name Course:");
            string namecourse = Console.ReadLine();
            Console.WriteLine("Enter Author:");
            string author = Console.ReadLine();
        }
        static void PrintCourseDetails(int id, string name, string author)
        {
            Console.WriteLine("{0} -- {1} -- {2} ", id, name, author);
        }

        static void Main(string[] args)
        {
            GetStudentInfomation();
            PrintStudentDetails("Ngo", "Dat", "22/11/2002");
            Console.WriteLine("==================================================================================================");
            GetTeacherInformation();
            PrintTeacherDetails("Dang", "Kim Thi", "dkthi@fpt.edu", "1/1/1");
            Console.WriteLine("==================================================================================================");
            GetCourseInformation();
            PrintCourseDetails(1, "C#", "jame");
        }
    }
}
