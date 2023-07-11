using StoreApp;

var store = new Store();
Console.WriteLine(store[1]);
Console.WriteLine(store[2]);

Console.WriteLine("Enter the product name: ");
var productName = Console.ReadLine();
Console.WriteLine(store[productName]);

Console.ReadKey();