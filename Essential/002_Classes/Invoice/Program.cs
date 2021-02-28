using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("232224", "Shop", "Factory");
            invoice1.Article = Article.Earphones;
            invoice1.Quantity = 6;
            invoice1.PrintInfo();

            Invoice invoice2 = new Invoice("21", "Autocenter", "VW");
            invoice2.Article = Article.Passat;
            invoice2.Quantity = 100;
            invoice2.PrintInfo();

            Console.ReadKey();
        }
    }
}
