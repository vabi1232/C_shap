using System;

namespace Moduel2_Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("NGODAT");
            var employee3 = new BusinessEmployee("Luong Tien");
            Console.WriteLine(employee1.employeeStatus()+"\n"+employee2.employeeStatus()+"\n"+employee3.employeeStatus());
        }
    }
}
