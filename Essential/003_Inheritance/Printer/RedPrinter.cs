using Shared;

namespace Printer
{
    class RedPrinter : Printer
    {
        public void Print(string text)
        {
            FormattingConsoleOutput.ColorsConsoleOutput(text, System.ConsoleColor.Red);
        }
    }
}
