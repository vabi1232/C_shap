using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies1
{
    class AtomInfo
    {
       public int ato_number;
       public string ato_sym;
        public string ato_name;
        public float ato_weight;
        AtomInfo[] Atom = new AtomInfo[10];
        int a, end;
        public Boolean accept()
        {
            Atom[a] = new AtomInfo();
            Console.WriteLine("Enter Atomic Number:");
            Atom[a].ato_number = int.Parse(Console.ReadLine());
            if (Atom[a].ato_number != 0)
            {
                Console.WriteLine("Enter Atom Symbol: ");
                Atom[a].ato_sym = Console.ReadLine();
                Console.WriteLine("Enter Atom Name: ");
                Atom[a].ato_name = Console.ReadLine();
                Console.WriteLine("Enter Atom Weight: ");
                Atom[a].ato_weight = float.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("End");
                end = a;
                return false;
            }
          
            return true;
        }
        public void Display()
        {
            for (a = 0; a < end; a++)
            {
                Console.WriteLine("{0} {1} {2} {3}", Atom[a].ato_number, Atom[a].ato_sym, Atom[a].ato_name, Atom[a].ato_weight);
            }
        }
    }
}
