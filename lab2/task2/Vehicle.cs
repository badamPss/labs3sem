using System;

namespace lab2
{
    public abstract class Vehicle
    {
        public (double X, double Y) Coordinates { get; }
        public decimal Price { get; }
        public double Speed { get; }  
        public int Year { get; }

        protected Vehicle((double X, double Y) coordinates, decimal price, double speed, int year)
        {
            Coordinates = coordinates;
            Price = price;
            Speed = speed;
            Year = year;
        }

        public override string ToString() =>
            $"{GetType().Name}: coords=({Coordinates.X},{Coordinates.Y}), price={Price}, speed={Speed}, year={Year}";
    }

    public sealed class Plane : Vehicle
    {
        public double Height { get; }    
        public int Passengers { get; }

        public Plane((double X, double Y) coordinates, decimal price, double speed, int year,
                     double height, int passengers)
            : base(coordinates, price, speed, year)
        {
            Height = height;
            Passengers = passengers;
        }

        public override string ToString() =>
            base.ToString() + $", height={Height}, passengers={Passengers}";
    }

    public sealed class Car : Vehicle
    {
        public string Model { get; }

        public Car((double X, double Y) coordinates, decimal price, double speed, int year, string model)
            : base(coordinates, price, speed, year)
        {
            Model = model;
        }

        public override string ToString() =>
            base.ToString() + $", model={Model}";
    }

    public sealed class Ship : Vehicle
    {
        public int Passengers { get; }
        public string Port { get; }

        public Ship((double X, double Y) coordinates, decimal price, double speed, int year,
                    int passengers, string port)
            : base(coordinates, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override string ToString() =>
            base.ToString() + $", passengers={Passengers}, port='{Port}'";
    }
}
