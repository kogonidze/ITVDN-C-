using PrinterApp.Models;

Printer yellowPrinter = new YellowPrinter();
yellowPrinter.Print("Hello from yellow Printer");

Printer bluePrinter = new BluePrinter();
bluePrinter.Print("Hello from blue Printer");

Console.ReadKey();