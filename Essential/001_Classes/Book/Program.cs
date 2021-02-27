using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book HarryPotter = new Book("Harry Potter and the Chamber of secrets", "J.K.Rowling",
                "Chapter One: The worst birthday");
            HarryPotter.Show();
            Console.WriteLine(new string('-', 30));

            Book CodeComplete = new Book();
            CodeComplete.Show();
            Console.WriteLine(new string('-', 30));

            CodeComplete.Author = "Steve McConnel";
            CodeComplete.Title = "Code Complete";
            CodeComplete.Content = "Introduction to ...";

            CodeComplete.Show();
            Console.WriteLine(new string('-', 30));

        }
    }
}
