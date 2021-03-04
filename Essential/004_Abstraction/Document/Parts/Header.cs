using System;

namespace Document.Parts
{
    class Header : DocumentPart
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
