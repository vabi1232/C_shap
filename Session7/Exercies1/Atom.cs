using System;

namespace Exercies1
{
    class Atom
    {
        public static void Main(string[] args)
        {
            AtomInfo atom = new AtomInfo();
            Console.WriteLine("Atomic Information");
            Console.WriteLine("===============================");
            while (atom.accept())
            {
                atom.accept();
            }
            Console.WriteLine("===============================");
            atom.Display();
            Console.ReadLine();
        }
    }

}
