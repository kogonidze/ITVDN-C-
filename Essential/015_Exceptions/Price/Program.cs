using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var myBasket = new MyBasket();

                myBasket.AddProducts();

                Console.WriteLine(myBasket["Evroopt"]);
                Console.WriteLine(myBasket["Wallmart"]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Price must be numeric!");
            }
            catch (ShopNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
