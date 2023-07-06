using DocumentHandlerApp;

Console.WriteLine("Enter the filename: ");
var filename = Console.ReadLine();

var processor = new Processor();
processor.ChooseDocument(filename);

processor.Create();
processor.Open();
processor.Change();
processor.Save();

Console.ReadKey();