using BookExercise;

var book = new Book();

Console.WriteLine("Enter the author of the book: ");
book.Author = Console.ReadLine();

Console.WriteLine("Enter the title of the book: ");
book.Title = Console.ReadLine();

Console.WriteLine("Enter the content of the book: ");
book.Content = Console.ReadLine();

book.Show();

Console.ReadKey();