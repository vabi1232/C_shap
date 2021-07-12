using System;

namespace Codesnipet1
{
    class Program
    {
        public abstract class Animal
        { 
//Non-abstract method implementation public void Eat() bbbbbbbbbbbbb
        Console.WriteLine("Every animal eats food in order to survive");
        }
        //Abstract method declaration 
        public abstract void AnimalSound();
        public abstract void Habitat();
    }
}

