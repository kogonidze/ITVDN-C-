using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var yellowPrinter = new YellowPrinter();
            yellowPrinter.Print(Constants.text);

            Printer printer = yellowPrinter as Printer;
            if (printer != null)
            {
                printer.Print(Constants.text);
            }
            else
            {
                Console.WriteLine(Constants.errorMsg);
            }


            YellowPrinter yellowPrinter2 = printer as YellowPrinter;

            if (yellowPrinter2 != null)
            {
                yellowPrinter2.Print(Constants.text);
            }
            else
            {
                Console.WriteLine(Constants.errorMsg);
            }
          
            var redPrinter = new RedPrinter();
            redPrinter.Print(Constants.text);

            printer = redPrinter as Printer;
            if (printer != null)
            {
                printer.Print(Constants.text);
            }
            else
            {
                Console.WriteLine(Constants.errorMsg);
            }

            yellowPrinter = printer as YellowPrinter;

            if (yellowPrinter != null)
            {
                yellowPrinter.Print(Constants.text);
            }
            else
            {
                Console.WriteLine(Constants.errorMsg);
            }
        }
    }
}
