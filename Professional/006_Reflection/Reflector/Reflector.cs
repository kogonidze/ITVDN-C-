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
                        PrintConstructorInfo(member as ConstructorInfo);
                        break;
                    case MemberTypes.Event:
                        PrintEventInfo(member as EventInfo);
                        break;
                    case MemberTypes.Field:
                        PrintFieldInfo(member as FieldInfo);
                        break;
                    case MemberTypes.Method:
                        PrintMethodInfo(member as MethodInfo);
                        break;
                    case MemberTypes.Property:
                        PrintPropertyInfo(member as PropertyInfo);
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

            PrintParametersInfo(method);


            Console.WriteLine();
        }

        private static void PrintParametersInfo(MethodInfo method)
        {
            var parameters = method.GetParameters();

            Console.WriteLine($"Method has {parameters.Length} parameters");

            foreach (var parameter in parameters)
            {
                Console.WriteLine($"Name: {parameter.Name}");
                Console.WriteLine($"Position: {parameter.Position}");
                Console.WriteLine($"Parameter type: {parameter.ParameterType}");
                Console.WriteLine($"Is in: {parameter.IsIn}");
                Console.WriteLine($"Is out: {parameter.IsOut}");
                Console.WriteLine($"Is return value: {parameter.IsRetval}");

                Console.WriteLine();
            }
        }

        private static void PrintFieldInfo(FieldInfo field)
        {
            Console.WriteLine($"Info about field {field.Name} with field type {field.FieldType}");

            Console.WriteLine($"Is private: {field.IsPrivate}");
            Console.WriteLine($"Is public: {field.IsPublic}");
            Console.WriteLine($"Is static: {field.IsStatic}");
            Console.WriteLine($"Is literal: {field.IsLiteral}");
            Console.WriteLine($"Declaring type: {field.DeclaringType}");
            Console.WriteLine($"Member type: {field.MemberType}");

            Console.WriteLine();
        }

        private static void PrintPropertyInfo(PropertyInfo property)
        {
            Console.WriteLine($"Info about property {property.Name} with field type {property.PropertyType}");

            Console.WriteLine($"Can read: {property.CanRead}");
            Console.WriteLine($"Can write: {property.CanWrite}");
            Console.WriteLine($"Get method: {property.GetMethod}");
            Console.WriteLine($"Set method: {property.SetMethod}");

            Console.WriteLine();
        }

        private static void PrintConstructorInfo(ConstructorInfo constructor)
        {
            Console.WriteLine($"Info about constructor {constructor.Name}");

            Console.WriteLine($"Is public: {constructor.IsPublic}");
            Console.WriteLine($"Is static: {constructor.IsStatic}");
            Console.WriteLine($"Is private: {constructor.IsPrivate}");
            Console.WriteLine($"Is hide by signature: {constructor.IsHideBySig}");
            Console.WriteLine($"Declaring type: {constructor.DeclaringType}");
            

            Console.WriteLine();
        }

        private static void PrintEventInfo(EventInfo @event)
        {
            Console.WriteLine($"Info about event {@event.Name}");
            Console.WriteLine($"Event handler type: {@event.EventHandlerType}");

            Console.WriteLine();
        }
    }
}
