using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduel2_Lab01
{
    abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeID;
        private static int employeeCount = 1;
       
        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int Id
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public Employee(String name,double salary)
        {
            this.Name = name;
            this.BaseSalary = salary;
            this.Id = employeeCount++;
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.Id;
        }
        public String toString()
        {
            return this.Id + " " + this.Name;

        }

        public abstract String employeeStatus();
    }
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        public TechnicalEmployee(String name) : base(name, 75000)
        {
           
        }
        public override string employeeStatus()
        {
            return this.toString() +" "+"has" + this.successfulCheckIns +"successful check ins";
        }
    }
    class BusinessEmployee: Employee
    {
        public double bounsBudget = 1000;

        public BusinessEmployee(String name) : base(name, 50000)
        {

        }
        public override string employeeStatus()
        {
            return this.toString() + " " + "with a budget of" +this.bounsBudget;
        }
    }
}
