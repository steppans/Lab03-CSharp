using System.Diagnostics;

namespace ClassLibrary03
{
    public class Vector: IEquatable<Vector>
    {                           
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z) => (X, Y, Z) = (x, y, z);
       
        private double CountSize() => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        public static Vector operator +( in Vector left, in Vector right) => new Vector(left.X + right.X, left.Y + right.Y, left.Z + right.Z);

        public static double operator *(in Vector left, in Vector right) => left.X * right.X + left.Y * right.Y + left.Z * right.Z;  
        
        public static Vector operator *(in Vector left, double a) => new Vector(a * left.X, a * left.Y, a * left.Z);

        public static Vector operator *(double a, in Vector right) => new Vector(a * right.X, a * right.Y, a * right.Z);

        // Operators of comparing
        public static bool operator ==(in Vector left, in Vector right) => left.CountSize() == right.CountSize();

        public static bool operator !=(in Vector left, in Vector right) => !(left == right);

        public static bool operator <=(in Vector left, in Vector right) => left.CountSize() <= right.CountSize();

        public static bool operator >=(in Vector left, in Vector right) => left.CountSize() >= right.CountSize();

        public static bool operator <(in Vector left, in Vector right) => left.CountSize() < right.CountSize();

        public static bool operator >(in Vector left, in Vector right) => left.CountSize() > right.CountSize();

        // Equals() from IEquitable (for collections)
        public bool Equals(Vector? other)
        {
            switch (other)
            {
                case null:
                    return false;
                default:
                    return X == other.X && Y == other.Y && Z == other.Z;
            }
        }

        // Equals from Object (for testing)
        public override bool Equals(object? obj)
        {
            Vector? vectorObj = obj as Vector;
            return Equals(vectorObj);
        }

    }
}