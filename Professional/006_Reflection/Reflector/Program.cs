using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectorNS
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyFile = ConfigurationManager.AppSettings["AssemblyFile"];

            var assembly = Reflector.LoadAssembly(assemblyFile);

            Reflector.PrintAssemblyInfo(assembly);

            Console.ReadKey();
        }
    }
}
