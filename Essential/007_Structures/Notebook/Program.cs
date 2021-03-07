using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook macBook = new Notebook("Apple", "Macbook Air 2013", 3000);
            macBook.Show();

            Notebook asusX541 = new Notebook("ASUS", "X541");
            asusX541.Show();

            Console.WriteLine(macBook.Model);
            Console.WriteLine(asusX541.Price);

            Console.ReadKey();
        }
    }
}
