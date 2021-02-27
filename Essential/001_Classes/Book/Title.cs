using System;

namespace Book
{
    class Title
    {
        private string title;

        public Title()
        {
            title = "Title of the book";
        }

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Title: \"{title}\"");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
