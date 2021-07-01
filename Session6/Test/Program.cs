using System;

namespace Test
{
    class Dimensions
    {
        static double _length;
        static double _breadth;
        public static double Area()
        {
            return _length * _breadth;

        }
        public static void SetDimension(double numOne, double numTwo)
        {
            _length = numOne;
            _breadth = numTwo;
        }
    }
    class StaticMethods
    {
        static void Main(string[] args)
        {
            Dimensions.SetDimension(20.1, 18.3);
            Console.WriteLine("Area of Rectangle: " +
            Dimensions.Area());
        }
    }
}
