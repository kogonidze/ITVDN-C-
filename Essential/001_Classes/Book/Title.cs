namespace BookExercise;

internal class Title
{
    public string Data { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Title: {Data}.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
