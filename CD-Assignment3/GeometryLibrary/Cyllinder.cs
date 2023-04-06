public class Cylinder
{
    public double Radius { get; }
    public Point Base1 { get; }
    public Point Base2 { get; }

    public Cylinder(double radius, Point base1, Point base2)
    {
        Radius = radius;
        Base1 = base1;
        Base2 = base2;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Cylinder other = (Cylinder)obj;
        return Radius == other.Radius && Base1 == other.Base1 && Base2 == other.Base2;
    }

    public override int GetHashCode()
    {
        return Tuple.Create(Radius, Base1, Base2).GetHashCode();
    }

    public double Height()
    {
        // TODO: Calculate height of the cylinder
        throw new NotImplementedException();
    }

    public double BottomArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double Volume()
    {
        return BottomArea() * Height();
    }

    public double SurfaceArea()
    {
        // TODO: Calculate surface area of the cylinder
        throw new NotImplementedException();
    }
}