using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(2, 5, 6, 7);
            Block block2 = new Block(2, 5, 6, 7);
            Block block3 = new Block(3, 5, 1, 5);

            Console.WriteLine($"block1 equals block2: {block1.Equals(block2)}");
            Console.WriteLine($"block1 equals block2: {Equals(block1, block2)}");
            Console.WriteLine($"block1 equals block3: {block1.Equals(block3)}");

            Console.WriteLine($"block1 hashcode: {block1.GetHashCode()}");
            Console.WriteLine($"block2 hashcode: {block2.GetHashCode()}");

            Console.WriteLine($"block1 reference equals block2: {ReferenceEquals(block1, block2)}");
            Console.WriteLine($"block1.ToString() {block1}");
            Console.WriteLine($"block2.ToString() {block2}");

            Console.ReadKey();
        }
    }
}
