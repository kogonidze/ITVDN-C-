using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithTemperatureReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var assembly = Assembly.Load("Temperature");
                var type = assembly.GetType("TemperatureNS.Temperature");

                var temperature = Activator.CreateInstance(type, new decimal(10.0));

                var kelvinProperty = type.GetProperty("Kelvin");
                var toStringMethod = type.GetMethod("ToString", new Type[] { typeof(string), typeof(IFormatProvider) });

                Console.WriteLine(kelvinProperty.GetValue(temperature));
                
                Console.WriteLine(toStringMethod.Invoke(temperature, new object[] { "G", CultureInfo.CurrentCulture }));
                Console.WriteLine(toStringMethod.Invoke(temperature, new object[] { "K", CultureInfo.CurrentCulture }));
                Console.WriteLine(toStringMethod.Invoke(temperature, new object[] { "F", CultureInfo.CurrentCulture }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
