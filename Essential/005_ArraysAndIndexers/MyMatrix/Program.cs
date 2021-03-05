using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfColumns = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfColumns"]);
            var numOfRows = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRows"]);

            MyMatrix matrix = new MyMatrix(numOfRows, numOfColumns);
            matrix.ShowMatrix();
            matrix.ResizeMatrix(6, 6);
            matrix.ShowMatrix();
            matrix.ShowPartOfMatrix(1,4);

            Console.ReadKey();
        }
    }
}
