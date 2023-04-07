namespace BookExercise;

internal class Author
{
    public string Data { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Author: {Data}.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
