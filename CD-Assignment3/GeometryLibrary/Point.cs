using System.Diagnostics.CodeAnalysis;
public class Point
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double Magnitude()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public static Point operator -(Point a, Point b)
    {
        return new Point(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public override bool Equals([AllowNull] object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Point other = (Point)obj;
        return X == other.X && Y == other.Y && Z == other.Z;
    }

    public override int GetHashCode()
    {
        return Tuple.Create(X, Y, Z).GetHashCode();
    }
}