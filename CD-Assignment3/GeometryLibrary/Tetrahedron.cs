// A tetrahedron class
    public class Tetrahedron : IShape
    {
        // Four vertices of the tetrahedron
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public Point D { get; }

        public Tetrahedron(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Tetrahedron other = (Tetrahedron)obj;
            return A == other.A && B == other.B && C == other.C && D == other.D;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(A, B, C, D).GetHashCode();
        }

        public Point Centroid()
        {
            double x = (A.X + B.X + C.X + D.X) / 4;
            double y = (A.Y + B.Y + C.Y + D.Y) / 4;
            double z = (A.Z + B.Z + C.Z + D.Z) / 4;
            return new Point(x, y, z);
        }

        public double SurfaceArea()
        {
            // TODO: Calculate surface area of the tetrahedron
            throw new NotImplementedException();
        }
    }