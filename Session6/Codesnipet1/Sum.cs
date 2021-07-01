using System;

namespace Codesnipet1
{
    class Sum
    {
          public void Add(int numberOne, int numberTwo)
        {
            int addResult = numberOne + numberTwo;
            Console.WriteLine("Addition = " + addResult);
        }
        public static void Main(string[] args)
        {
            Sum s = new Sum();
            s.Add(1, 2);
         
        }
    }
}
