namespace PrinterApp.Models;

internal class Printer
{
    protected ConsoleColor Color { get; set; }

    public Printer(ConsoleColor color)
    {
        Color = color;
    }

    public virtual void Print(string value)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(value);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
