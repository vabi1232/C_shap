using System;

namespace Exercies1
{
    
    public abstract class Person
    {
        public string name;
        public string address;
        public string phone_number;
        public string email;
        public Person()
        {

        }
        public Person(string n, string a, string p, string e)
        {
            name = n;
            address = a;
            phone_number = p;
            email = e;
        }
        public  String toString()
        {
            return "Name: " + name + "Address: " + address + "Phone number: " + phone_number + "Email:" + email;
        }
   
        class Student : Person
        {
            public string pg;
            public Student(string n,string a,string p,string e,string pg) : base(n, a, p, e)
            {
                this.pg = pg;
            }
            public string display()
            {
                return "Student Name: " + name + "Address: " + address + "Phone number: " + phone_number + "Email: " + email + "Program: " + pg;
            
            }
        }
        abstract class Employee : Person
        {
            public string department;
            public float salary;
            public string dateHired;
            public int office_Hours;
            public int week;
            public Employee(string n, string a, string p, string e, string department, float salary, string dateHired, int office_Hours, int week):base(n, a, p, e)
            {

                this.department = department;
                this.salary = salary;
                this.dateHired = dateHired;
                this.office_Hours = office_Hours;
                this.week = week;
            }
            public abstract void CalculateBonus();
            public abstract void CalculateVacation();
        }
        class Faculty : Employee
        {
            string rank;
            public Faculty(string n, string a, string p,string e, string department, float salary, string dateHired, int office_Hours, int week, string rank) : base(n, a, p,e, department, salary, dateHired, office_Hours, week)
            {

                this.rank = rank;
            }
            public override void CalculateBonus()
            {
                Console.WriteLine(name + "'s Bonus: " + (salary * 0.05 + 1000));
            }
            public override void CalculateVacation()
            {
                if (rank == "Senior")
                {
                    week = week + 1;
                }
                if (office_Hours >= 10000)
                {
                    week = week + 5;
                }
                else
                {
                    week = week + 4;
                }
                Console.WriteLine(name + "'s Vacation: " + week + " week(s)");
            }
            public string display()
            {
                return "Faculty Name: " + name +" , "+ "Address: " + address+ " , " + "Phone number: " + phone_number + " , " + "Department: " + department + " , " + "Salary: " + salary + " , " + "Date: " + dateHired + " , " + "Office Hours: " + office_Hours + " , " + "Week" + week + " , " + "Rank: " + rank;
            }
        }
        class Staff : Employee
        {
            string title;
            public Staff(string n, string a, string p,string e, string department, float salary, string dateHired, int office_Hours, int week, string title) : base(n, a, p,e, department, salary, dateHired, office_Hours, week)
            {
                this.title = title;
            }
            public override void CalculateBonus()
            {
                Console.WriteLine(name + " Bonus: " + (salary * 0.06));
            }

            public override void CalculateVacation()
            {
                if (office_Hours >= 15000)
                {
                    week = week + 4;
                }
                else
                {
                    week = week + 3;
                }
                Console.WriteLine(name + " Vacation: " + week + " week");
            }
            public string display()
            {
                return "Staff Name:" + name + " , " + "Address: " +address+ " , " + "Phone number: " +phone_number+ " , " + "Email: " +email+ " , " + "Department: " + department + " , " + "Salary: " + salary + " , " + "Date: " + dateHired + " , " + "Office Hours: " + office_Hours + " , " + "Week: " + week + " , " + "Title: " + title;
            }
        }
        class run
        {
            static void Main(string[] args)
            {

                Console.WriteLine("==================================================================================================");
                Faculty fa = new Faculty("Ngo Dat", "Bac Ninh","99999999", "dat3578@gmail.com", "Sales", 30000000, "22/11/2002", 1200, 100, "Senior");
                Console.WriteLine(fa.display());
                fa.CalculateBonus();
                fa.CalculateVacation();

                Console.WriteLine("==================================================================================================");
                Staff st = new Staff("Thanh Dat", "Bac Ninh", "123456789", "dat3578@gmail.com", "delivery", 10000000, "22/11/2002", 1000, 50, "GODD CHOOPS");
                Console.WriteLine(st.display());
                st.CalculateBonus();
                st.CalculateVacation();

                Console.WriteLine("==================================================================================================");
            }
        }
    }
}
