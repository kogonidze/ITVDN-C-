using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = ConfigurationManager.AppSettings["InputFileName"];

            using (var fs = new FileStream(inputFile, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    GetProductInfoInCulture(sr, new CultureInfo("en-US"));

                    fs.Position = 0;
                    Console.WriteLine(new string('-', 50));
                    GetProductInfoInCulture(sr, new CultureInfo("be-BY"));

                    fs.Position = 0;
                    Console.WriteLine(new string('-', 50));
                    GetProductInfoInCulture(sr, new CultureInfo("de-DE"));

                    fs.Position = 0;
                    Console.WriteLine(new string('-', 50));
                    GetProductInfoInCulture(sr, new CultureInfo("ru-RU"));
                }
            }

            Console.ReadKey();
        }

        static void GetProductInfoInCulture(StreamReader sr, CultureInfo cultureInfo)
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                var productInfo = line.Split('-');
                var price = GetPriceValueInCurrency(Convert.ToDecimal(productInfo[1]), cultureInfo);


                Console.WriteLine($"Product name: {productInfo[0]} \t Price: {price.ToString("C", cultureInfo)}");
            }
        }

        static decimal GetPriceValueInCurrency(decimal price, CultureInfo cultureInfo)
        {
            switch (cultureInfo.Name)
            {
                case "en-US":
                    return price / new decimal(2.6);
                case "de-DE":
                    return price / new decimal(3.2);
                case "ru-RU":
                    return price * 30;

                default:
                    return price;
            }
        }
    }
}
