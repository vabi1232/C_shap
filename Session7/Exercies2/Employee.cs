using System;

namespace Exercies2
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string address;
        public long sin;
        public double salary;
        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "Name: " + firstName + " " + lastName +
                "\nAddress: " + address +
                "\nSin: " + sin +
                "\nSalary: " + salary;
        }
        public double Bonus(double bonus)
        {
            return salary * bonus / 100;
        }
        static void Main(string[] args)
        {
            Employee e = new Employee("Duong", "Tran", "40 Tran phu", 123456789, 2000000);
            Console.WriteLine(e.ToString());
            Console.WriteLine("Bonus: " + e.Bonus(50));
            Console.ReadLine();
        }

    }

}
