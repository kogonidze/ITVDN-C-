using System;

namespace Book
{
    class Author
    {
        private string author;

        public Author()
        {
            author = "Author of the book";
        }

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Author: \"{author}\"");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
