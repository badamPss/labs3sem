using System;

namespace lab3.Task2
{
    class Program
    {
        static void Main()
        {
            var c1 = new Car("Audi", "2.0TFSI", 240);
            var c2 = new Car("BMW", "3.0d", 250);
            var catalog = new CarsCatalog(c1, c2);

            for (int i = 0; i < catalog.Count; i++)
                Console.WriteLine(catalog[i]);

            Console.WriteLine("c1.Equals(c2)? " + c1.Equals(c2));
        }
    }
}
