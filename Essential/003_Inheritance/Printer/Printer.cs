using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Printer
{
    class Printer
    {
        public void Print(string value)
        {
            FormattingConsoleOutput.ColorsConsoleOutput(value, ConsoleColor.White);
        }
    }
}
