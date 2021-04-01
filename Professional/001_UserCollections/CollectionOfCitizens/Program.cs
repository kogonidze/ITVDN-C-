using CollectionOfCitizens.Citizens;
using CollectionOfCitizens.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCitizens
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var citizenCollection = new CitizenCollection();
                var indexOfCitizen = -1;

                citizenCollection.Add(new Student(1, "Petr", "Petrov", 1999, "MGU"));
                citizenCollection.Add(new Worker(2, "Andrei", "Andreev", 2001, "Microsoft"));
                citizenCollection.Add(new Retiree(3, "Ivan", "Ivanov", 1940));
                citizenCollection.Add(new Student(4, "Vasili", "Vasilev", 2001, "GRGU"));
                citizenCollection.Add(new Retiree(5, "Sergei", "Sergeev", 1954));
                citizenCollection.Add(new Worker(6, "Yuri", "Yuriev", 1983, "Mersedes"));
                //citizenCollection.Add(new Worker(6, "Yuri", "Yuriev", 1983, "Mersedes"));

                foreach (var citizen in citizenCollection)
                {
                    Console.WriteLine(citizen);
                }

                Console.WriteLine(new string('-', 50));

                Console.WriteLine(citizenCollection.ReturnLast(out indexOfCitizen));
                Console.WriteLine(new string('-', 50));

                Console.WriteLine(citizenCollection.Contains(new Retiree(3, "Ivan", "Ivanov", 1940), out indexOfCitizen));
                Console.WriteLine(citizenCollection.Contains(new Retiree(7, "Viktor", "Viktorov", 1940), out indexOfCitizen));
                Console.WriteLine(new string('-', 50));

                citizenCollection.Remove();
                citizenCollection.Remove(new Student(4, "Vasili", "Vasilev", 2001, "GRGU"));
                //citizenCollection.Remove(new Retiree(7, "Viktor", "Viktorov", 1940));

                foreach (var citizen in citizenCollection)
                {
                    Console.WriteLine(citizen);
                }
                Console.WriteLine(new string('-', 50));

                citizenCollection.Clear();
                foreach (var citizen in citizenCollection)
                {
                    Console.WriteLine(citizen);
                }

                //citizenCollection.Remove(new Retiree(7, "Viktor", "Viktorov", 1940));
                Console.WriteLine(new string('-', 50));
            }
            catch (CitizenCollectionEmptyException ex)
            {
                Console.WriteLine($"Type of exception: {ex.GetType()} Message: {ex.Message}");
            }
            catch (CitizenNotFoundException ex)
            {
                Console.WriteLine($"Type of exception: {ex.GetType()} Message: {ex.Message}");
            }
            catch (CitizensDuplicationAttemptException ex)
            {
                Console.WriteLine($"Type of exception: {ex.GetType()} Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message} Inner exception: {ex.InnerException}");
            }

            Console.ReadKey();
        }
    }
}
