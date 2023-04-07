namespace Polygon;

internal class Figure
{
    private List<Point> points;

    public string Name { get; set; }

    public double Perimeter { get => PerimeterCalculator(); }

    public Figure(Point a, Point b, Point c, Point d, Point e)
        : this(a, b, c, d)
    {
        points.Add(e);
    }

    public Figure(Point a, Point b, Point c, Point d)
        : this(a, b, c)
    {
        points.Add(d);
    }

    public Figure(Point a, Point b, Point c)
    {
        points = new List<Point>();
        points.AddRange(new Point[] { a, b, c });
    }

    public string ShowInfo()
        => $"Name: {Name}, Perimeter: {Perimeter}";

    private double PerimeterCalculator()
    {
        var perimeter = 0.0;

        for (int i = 0; i < points.Count; i++) 
        {
            if (i == points.Count - 1)
            {
                perimeter += LengthSide(points[i], points[0]);
                break;
            }

            perimeter += LengthSide(points[i], points[i + 1]);
        }

        return perimeter;
    }

    private double LengthSide(Point A, Point B)
        => Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
}
