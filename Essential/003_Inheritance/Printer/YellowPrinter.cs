using Shared;

namespace Printer
{
    class YellowPrinter : Printer
    {
        public void Print(string text)
        {
            FormattingConsoleOutput.ColorsConsoleOutput(text, System.ConsoleColor.Yellow);
        }
    }
}
