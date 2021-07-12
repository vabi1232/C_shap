using System;

namespace Codesnipet6
{
    class Animal
    {
 // Ở animal khởi tạo 2 phương thúc một thức kh có dữ liệu một phương thức có truyền vào dữ liệu là một string (chuỗi)
//
        public Animal()
        {
            Console.WriteLine("Animal contrucstor without parametters");
        }
        public Animal(String name)
        {
            Console.WriteLine("Animal constructor with a string parameters");

        }
    }
    class Canie : Animal
    {
        public Canie() 
        {
            Console.WriteLine("Derived Canine");
        }
        static void Main(string[] args)
        {
            Canie objCanie = new Canie();
        }
    }
}
