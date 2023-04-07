using RectangleExercise;

Console.WriteLine("Enter side1 value: ");

if (!double.TryParse(Console.ReadLine(), out double side1))
{
    Console.WriteLine("Side1 must be a double value!");
    Environment.Exit(-1);
}

Console.WriteLine("Enter side2 value: ");

if (!double.TryParse(Console.ReadLine(), out double side2))
{
    Console.WriteLine("Side2 must be a double value!");
    Environment.Exit(-1);
}

var rectangle = new Rectangle(side1, side2);
Console.WriteLine(rectangle.ShowInfo());

Console.ReadKey();