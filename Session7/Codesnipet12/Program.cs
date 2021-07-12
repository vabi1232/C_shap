using System;

namespace Codesnipet12
{
    class Area
    {
      static int CalculateArea(int len ,int wide)
        {
            return wide * len;

        }
        static double CalculateArea(double valOne, double valTwo)
        {
            return 0.5 * valOne * valTwo;
        }
        static void Main(string[] args)
        {
            int lenght = 10;
            int breadth = 22;
            double tbase = 2.5;
            double theight = 1.5;
            Console.WriteLine("Area of Rectangle: " +CalculateArea(lenght,breadth));
            Console.WriteLine("Area of triangle: " +CalculateArea(tbase, theight));
        }
    }
}
