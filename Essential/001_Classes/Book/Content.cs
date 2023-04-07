namespace BookExercise;

internal class Content
{
    public string Data { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Content: {Data}.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
