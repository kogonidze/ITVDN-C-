using Polygon;

var triangle = new Figure(new Point(10, 2, "A"), new Point(6, 6, "B"), new Point(8, 0, "C"));
triangle.Name = "ABC";
Console.WriteLine(triangle.ShowInfo());

var square = new Figure(new Point(-2, 4, "A"), new Point(2, 4, "B"),
    new Point(2, 0, "C"), new Point(-2, 0, "D"));

square.Name = "ABCD";
Console.WriteLine(square.ShowInfo());

var pentagon = new Figure(new Point(-4, 4, "A"), new Point(6, 8, "B"),
    new Point(8, 4, "C"), new Point(4, 2, "D"), new Point(-2, 2, ""));

pentagon.Name = "ABCDE";
Console.WriteLine(pentagon.ShowInfo());

Console.ReadKey();