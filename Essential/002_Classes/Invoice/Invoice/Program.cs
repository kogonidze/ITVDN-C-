using InvoiceProject;

var invoice = new Invoice(12345, "Shop", "Factory");
invoice.Article = "Smartphone";
invoice.Quantity = 100;

var price = invoice.CalculatePrice(false);
var priceWithNds = invoice.CalculatePrice(true);

Console.WriteLine($"Price: {price}, price with NDS: {priceWithNds}");

Console.ReadKey();