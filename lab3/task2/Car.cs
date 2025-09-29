using System;

namespace lab3.Task2
{
    public class Car : IEquatable<Car>
    {
        public string Name { get; }
        public string Engine { get; }
        public int MaxSpeed { get; }

        public Car(string name, string engine, int maxSpeed)
        {
            Name = name;
            Engine = engine;
            MaxSpeed = maxSpeed;
        }

        public override string ToString() => Name;

        public bool Equals(Car? other)
        {
            if (other is null) return false;
            return Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;
        }

        public override bool Equals(object? obj) => Equals(obj as Car);
        public override int GetHashCode() => HashCode.Combine(Name, Engine, MaxSpeed);
    }

    public class CarsCatalog
    {
        private readonly Car[] _cars;

        public CarsCatalog(params Car[] cars)
        {
            _cars = cars ?? Array.Empty<Car>();
        }

        public string this[int index]
        {
            get
            {
                var car = _cars[index];
                return $"{car.Name} — двигатель: {car.Engine}";
            }
        }

        public int Count => _cars.Length;
    }
}