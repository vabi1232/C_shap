using System;

namespace Codesnipet2
{
    class Animal
    {
       public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
  public void DoSomething()
        {
            Console.WriteLine("Every animlas does something.");
        }
    }
    class Cat : Animal
    {
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
            objCat.DoSomething();
        }
    }
}
