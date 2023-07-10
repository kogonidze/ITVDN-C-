using WorkWithArrayApp;

var myArray = new MyArray(5);
Console.WriteLine($"Max: {myArray.Max()}");
Console.WriteLine($"Min: {myArray.Min()}");
Console.WriteLine($"Sum: {myArray.Sum()}");
Console.WriteLine($"Average: {myArray.Average()}");
myArray.PrintOddValues();

Console.ReadKey();