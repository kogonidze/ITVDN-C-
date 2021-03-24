using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Exceptions;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Company company = new Company("Astolid");
                for (int i = 0; i < 5; i++)
                {
                    company.AddWorker();
                }

                company.GetWorkersWithMoreExperienceThanInput(15);

                company.AddWorker();
            }
            catch (FullStateException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
            catch (IncorrectYearException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Inner exception: {ex.InnerException}");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
