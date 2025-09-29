using System;

namespace lab2.Task2
{
    class Program
    {
        static void Main()
        {
            Vehicle[] vehicles =
            {
                new Plane((55.75, 37.62), 5_000_000m, 850, 2015, height: 10000, passengers: 180),
                new Car((59.93, 30.31), 1_800_000m, 160, 2020, model: "Sedan X"),
                new Ship((46.48, 30.73), 12_000_000m, 45, 2012, passengers: 800, port: "Одесса")
            };

            foreach (var v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }
}