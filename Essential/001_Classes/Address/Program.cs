using AddressExercise;

var address = new Address();

address.Index = "12345";
address.Country = "Belarus";
address.City = "Minsk";
address.Street = "Kudykina";
address.House = "1";
address.Apartment = "1";

Console.WriteLine(address.ShowInfo());

Console.ReadKey();