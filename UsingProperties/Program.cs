using System;

namespace UsingProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals Horse = new Animals("Mr.Ed", "horse","neigh","hay", "transportation","back of the farm", "medium");
            //purposely put the invalid size to demonstates the private getter and setter function
            Animals Cow = new Animals("Milkshake", "cow", "Moo", "grass", "beef", "backyard", "Mr.Bean");
            Console.WriteLine(Horse.Size);
            //should out put a invalid size string
            Console.WriteLine(Cow.Size);
        }
    }
}
