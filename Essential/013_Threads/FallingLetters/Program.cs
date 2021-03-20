using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingLetters
{
    class Program
    {
        public static object syncRoot = new object();

        static void Main(string[] args)
        {
            var matrix = Matrix.GetMatrix();
            while (true)
            {
                Thread.Sleep(1500);
                new Thread(Matrix.MoveLetters).Start();
            }
        }
    }
}
