using System;
using System.Collections;
using System.Collections.Generic;


namespace IssyesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Issues with Non-Generic Collections-****");
            UserPersonCollecion();
            Console.WriteLine();
            UseGenericList();
            Console.WriteLine();

        }
        private static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;
            object boxedInt = myInt;
            try
            {
                long unboxedInt = (long)boxedInt;
            }catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            Console.ReadLine();
        }
        static void ArrayListOfRandomObjects()
        {
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);

        }
        static void UserPersonCollecion()
        {
            Console.WriteLine("***Custom person collection****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpon", 40));
            myPeople.AddPerson(new Person("Ngo", "dat", 40));
            myPeople.AddPerson(new Person("chi", "thanh", 40));
            myPeople.AddPerson(new Person("nguyen", "tuan", 40));
            myPeople.AddPerson(new Person("quang", "tuan", 40));
            foreach (Person p in myPeople)
                Console.WriteLine(p);
        }

        static void UseGenericList()
        {
            Console.WriteLine("****Function wiht Generic ****\n");
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Prank", "Black", 30));
            Console.WriteLine(morePeople[0]);

            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];
        }
    }
}
