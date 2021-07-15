using System;

namespace Moduel3_Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;

            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());
            int result = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} and {second} is : {result}");
        }
        static int Divide (int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second vlaue");
            }
            return result;
        }
    }
}
