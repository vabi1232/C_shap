using System;

namespace Codesnipet3
{
    class Animal
    {
        protected string Food;
        protected string Activity;

    }
    class Cat : Animal
    {
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Food = "Mouse";
            objCat.Activity = "laze around";
            Console.WriteLine("The cat loves to eat" + objCat.Food + ".");
            Console.WriteLine("The cat Loves to" + objCat.Activity + ".");
        }
    }
}
