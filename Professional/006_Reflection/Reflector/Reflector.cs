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

        internal static void PrintTypesInfo(Assembly assembly)
        {
            var types = assembly.GetTypes();

            Console.WriteLine("Info about types: ");

            foreach (var type in types)
            {
                Console.WriteLine($"Name: {type.Name}");
                Console.WriteLine($"Fullname: {type.FullName}");
                Console.WriteLine($"Is Class: {type.IsClass}");
                Console.WriteLine($"Is abstract: {type.IsAbstract}");
                Console.WriteLine($"Is serializable: {type.IsSerializable}");
                Console.WriteLine($"Base type: {type.BaseType}");
                Console.WriteLine($"GUID: {type.GUID}");

                Console.WriteLine();
                Console.WriteLine("Members info: ");

                PrintMembersInfo(type);
            }
        }

        private static void PrintMembersInfo(Type type)
        {
            var members = type.GetMembers();

            foreach (var member in members)
            {
                Console.WriteLine($"Member type: {member.MemberType}, Member name: {member.Name}");

                switch (member.MemberType)
                {
                    case MemberTypes.Constructor:
                        break;
                    case MemberTypes.Event:
                        break;
                    case MemberTypes.Field:
                        break;
                    case MemberTypes.Method:
                        PrintMethodInfo(member as MethodInfo);
                        break;
                    case MemberTypes.Property:
                        break;
                    case MemberTypes.TypeInfo:
                        break;
                    case MemberTypes.Custom:
                        break;
                    case MemberTypes.NestedType:
                        break;
                    case MemberTypes.All:
                        break;
                    default:
                        break;
                }

            }
        }

        private static void PrintMethodInfo(MethodInfo method)
        {
            Console.WriteLine($"Info about method {method.Name}");

            Console.WriteLine($"Is abstract: {method.IsAbstract}");
            Console.WriteLine($"Is private: {method.IsPrivate}");
            Console.WriteLine($"Is public: {method.IsPublic}");
            Console.WriteLine($"Is static: {method.IsStatic}");
            Console.WriteLine($"Is virtual: {method.IsVirtual}");
            Console.WriteLine($"Declaring type: {method.DeclaringType}");
            Console.WriteLine($"Calling convention: {method.CallingConvention}");

            Console.WriteLine();
        }
    }
}
