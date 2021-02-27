using System;

namespace Book
{
    class Content
    {
        private string content;

        public Content()
        {
            content = "Content of the book";
        }

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Content: \"{content}\"");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
