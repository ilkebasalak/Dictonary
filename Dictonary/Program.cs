using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> animal = new MyDictonary<int, string>();

            animal.Add(01, "Butterfly");
            animal.Add(02, "Rabbit");
            animal.Add(03, "Cat");
            animal.Add(04, "Turtle");
            animal.Add(05, "Dog");
            animal.Add(06, "Owl");
            animal.Add(07, "Lion");
            animal.Add(08, "Panda");
            animal.Add(09, "Dolphin");
            animal.Add(10, "Bear");
            animal.Add(11, "Bird");
            animal.Add(12, "Fish");


            foreach (var number in animal.Keys)
            {
                Console.WriteLine(number);
            }

            foreach (var hayvan in animal.Values)
            {
                Console.WriteLine(hayvan);
            }


        }
    }
}
