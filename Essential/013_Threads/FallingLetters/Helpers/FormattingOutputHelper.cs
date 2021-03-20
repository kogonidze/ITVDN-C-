using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingLetters.Helpers
{
    public abstract class FormattingOutputHelper
    {
        public static void ColouredOutputInConsole(char ch, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(ch);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
