public class Hexagon : Shape
{
    public double SideLength { get; }

    public Hexagon(double sideLength)
    {
        if (sideLength <= 0)
            throw new ArgumentException("Side must be positive.");

        SideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return (3 * Math.Sqrt(3) / 2) * SideLength * SideLength;
    }
}