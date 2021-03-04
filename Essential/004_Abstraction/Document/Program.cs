using Document.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Header of document");
            document.Body = "Body of document";
            document.Footer = "Footer of document";

            document.Show();

            Console.ReadKey();

        }
    }
}
