using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies2
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public void SetMe(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight {Weight}");
        }
    }
}
