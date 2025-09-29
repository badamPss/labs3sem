using System;

namespace lab3.Task1
{
    public struct Vector
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Vector(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }

        public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);

        public static Vector operator +(Vector a, Vector b) =>
            new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static double operator *(Vector a, Vector b) =>
            a.X * b.X + a.Y * b.Y + a.Z * b.Z;

        public static Vector operator *(Vector a, double k) =>
            new Vector(a.X * k, a.Y * k, a.Z * k);

        public static Vector operator *(double k, Vector a) => a * k;

        public static bool operator >(Vector a, Vector b) => a.Length > b.Length;
        public static bool operator <(Vector a, Vector b) => a.Length < b.Length;
        public static bool operator >=(Vector a, Vector b) => a.Length >= b.Length;
        public static bool operator <=(Vector a, Vector b) => a.Length <= b.Length;

        public override string ToString() =>
            $"({X}, {Y}, {Z}), |v|={Length:F2}";
    }
}