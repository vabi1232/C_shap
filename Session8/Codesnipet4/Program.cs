using System;

namespace Codesnipet4
{
    interface IAnimal
    {
        void Habitat();
    }
    class Dog:IAnimal
    {
        public void Habitat()
        {
            Console.WriteLine("Can be houserd with human begins");
        }
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            Console.WriteLine(objDog.GetType().Name);
            objDog.Habitat();
        }
    }
}
