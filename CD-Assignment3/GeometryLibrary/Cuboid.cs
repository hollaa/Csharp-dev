public class Cuboid : IShape
{
    public Point A { get; }
    public Point B { get; }
    public Point C { get; }
    public Point D { get; }
    public Point E { get; }
    public Point F { get; }
    public Point G { get; }
    public Point H { get; }

    public Cuboid(Point a, Point b, Point c, Point d, Point e, Point f, Point g, Point h)
    {
        A = a;
        B = b;
        C = c;
        D = d;
        E = e;
        F = f;
        G = g;
        H = h;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Cuboid other = (Cuboid)obj;
        return A == other.A && B == other.B && C == other.C && D == other.D &&
               E == other.E && F == other.F && G == other.G && H == other.H;
    }

    public override int GetHashCode()
    {
        return Tuple.Create(A, B, C, D, E, F, G, H).GetHashCode();
    }

    public Point Centroid()
    {
        double x = (A.X + B.X + C.X + D.X + E.X + F.X + G.X + H.X) / 8;
        double y = (A.Y + B.Y + C.Y + D.Y + E.Y + F.Y + G.Y + H.Y) / 8;
        double z = (A.Z + B.Z + C.Z + D.Z + E.Z + F.Z + G.Z + H.Z) / 8;
        return new Point(x, y, z);
    }

    public double Volume()
    {
        double length = (B - A).Magnitude();
        double width = (E - A).Magnitude();
        double height = (D - A).Magnitude();
        return length * width * height;
    }

    public double SurfaceArea()
    {
        double length = (B - A).Magnitude();
        double width = (E - A).Magnitude();
        double height = (D - A).Magnitude();
        return 2 * (length * width + length * height + width * height);
    }
}