using DocumentHandler.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file: ");
            var file = Console.ReadLine();

            var lastIndex = file.LastIndexOf('.');
            var ext = file.Substring(lastIndex + 1);

            AbstractHandler handler = null;

            switch (ext.ToLower())
            {
                case "txt":
                    handler = new TXTHandler();
                    break;
                case "doc":
                    handler = new DOCHandler();
                    break;
                case "xml":
                    handler = new XMLHandler();
                    break;
                default:
                    Console.WriteLine("We can`t handle this type of file!");
                    break;
            }

            if (handler != null)
            {
                handler.Create();
                handler.Change();
                handler.Save();
                handler.Open();
            }

            Console.ReadKey();
        }
    }
}
