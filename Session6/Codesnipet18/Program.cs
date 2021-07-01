using System;

namespace Codesnipet18
{
    class Multiplication
    {
        static int _valueOne = 10;
        static int _product;
        static Multiplication()
        {
            Console.WriteLine("Static Constructor initialized");
            _product = _valueOne * _valueOne;
        }
        public static void Method()
        {
            Console.WriteLine("Value of product = " +_product);
        }
        static void Main(string[] args)
        {
            Multiplication.Method();
        }
    }
}
