using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            Material brickTiles = new Material("brick", "tiles");
            var house = new House(brickTiles, 10000);

            Console.WriteLine($"Surface cloning: ");
            var house2 = house.Clone();

            Console.WriteLine(house);
            Console.WriteLine(house2);
            Console.WriteLine(new string('-', 50));

            house2.Price = 20000;
            house2.Material.Roof = "slate";

            Console.WriteLine(house);
            Console.WriteLine(house2);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Deep cloning: ");
            var house3 = house.DeepClone();

            Console.WriteLine(house);
            Console.WriteLine(house3);
            Console.WriteLine(new string('-', 50));

            house3.Price = 10000;
            house3.Material.Roof = "brick";

            Console.WriteLine(house);
            Console.WriteLine(house3);
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();
        }
    }
}
