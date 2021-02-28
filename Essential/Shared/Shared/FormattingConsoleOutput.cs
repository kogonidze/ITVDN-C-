using System;


namespace Shared
{
    public abstract class FormattingConsoleOutput
    {
        public static void ColorsConsoleOutput(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
