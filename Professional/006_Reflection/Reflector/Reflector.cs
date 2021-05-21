using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectorNS
{
    public abstract class Reflector
    {
        internal static Assembly LoadAssembly(string assemblyFile)
        {
            try
            {
                var assembly = Assembly.LoadFrom(assemblyFile);
                Console.WriteLine($"Assembly `{assembly.FullName}` was successfully loaded!");
                Console.WriteLine();

                return assembly;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        internal static void PrintAssemblyInfo(Assembly assembly)
        {
            Console.WriteLine($"Info about assembly `{assembly}`: ");
            Console.WriteLine($"Manifest module: {assembly.ManifestModule}");
            Console.WriteLine($"Full name: {assembly.FullName}");
            Console.WriteLine($"Location: {assembly.Location}");
            Console.WriteLine($"ImageRuntimeVersion: {assembly.ImageRuntimeVersion}");
            Console.WriteLine($"Is dynamic: {assembly.IsDynamic}");
            Console.WriteLine($"Is fully trusted: {assembly.IsFullyTrusted}");

            Console.WriteLine("Attributes: ");
            foreach (var item in assembly.CustomAttributes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
        }
    }
}
