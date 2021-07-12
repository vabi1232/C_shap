using System;

namespace Codesnipet8
{
    class Aniaml
    {
      public virtual void Eat()
        {
            Console.WriteLine("Every animals eats something");

        }
        protected void DoSomeThing()
        {
            Console.WriteLine("Every animal does something");

        }
    }
    class Cat : Aniaml
    {
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
        }
    }
}
