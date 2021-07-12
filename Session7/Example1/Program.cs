using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program

    {
        public static void Main(string[] args)
        {
            Car myCar;
            Console.WriteLine("Creating a car object and assigning" + "it's memory location to my Car");
            myCar = new Car();
            myCar.make = "Toyota";
            myCar.model="MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model= " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt=" + myCar.yearBuilt);
            myCar.Start();
            myCar.Stop();
           
            Console.WriteLine("Creating another Car object  and"+"assigning its memory location to redPorsche");
            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            Console.WriteLine("redPorsche is a " + redPorsche.model);
            Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            Console.WriteLine("myCar details:");
            Console.WriteLine("myCar.make = " + myCar.make);
            Console.WriteLine("myCar.model = " + myCar.model);
            Console.WriteLine("myCar.color = " + myCar.color);
            Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);
            myCar = null;
        }
    }
}
