using System;

namespace Self_Assessnet_lAB
{
    abstract class Person
    {
        public string firstName;
        public string lastName;
        public string email;
        public string phone;
        public Person(string firstName, string lastName, string email, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
        }
        public virtual String toString()
        {
            return "FirstName: " +firstName+ "LastName: " +lastName+ "Email: " + "Phone: " +phone;
        }

    }
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string email, string phone) : base(firstName, lastName, email, phone)
        {
            
        }

        public string PrintGradeTest()
        {
            return firstName + lastName + "TEST GOOD";
        }
        public override string toString()
        {
            return "FirstName: " + firstName + "LastName: " + lastName + "Email: " + "Phone: " + phone;
        }
    }
    class Student: Person
    {
        private static int testCount = 1;
        public int idtest;
        public Student(string firstName, string lastName, string email, string phone) : base(firstName, lastName, email, phone)
        {
            this.idtest = testCount++;
        }
        public string PrintTakeTest()
        {
            return firstName + lastName + " " + "Lam bai so " + this.idtest;
        }
        public override string toString()
        {
            return "FirstName: " + firstName + "LastName: " + lastName + "Email: " + "Phone: " + phone;
        }
        public static void Main(string[] args)
        {
            Teacher t = new Teacher("Dang", "Kim Thi", "dkthi@fpt.edu.vn", "0999999999999");
            Console.WriteLine(t.toString());
            Console.WriteLine(t.PrintGradeTest());
            Console.WriteLine("==================================================");
            Student s = new Student("Ngo Chi", "Thanh Dat", "dat3578@gmail.com", "0394480757");
            Console.WriteLine(t.toString());
            Console.WriteLine(s.PrintTakeTest());
            Console.WriteLine("------------------------------");
            Student s1 = new Student("Ngo ", "Thanh Dat", "dat3578@gmail.com", "0394480757");
            Console.WriteLine(t.toString());
            Console.WriteLine(s.PrintTakeTest());
            Console.WriteLine("------------------------------");
            Student s2 = new Student("Ngo ", " Dat", "dat3578@gmail.com", "0394480757");
            Console.WriteLine(t.toString());
            Console.WriteLine(s.PrintTakeTest());
        }
    }
}
