using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Exceptions;

namespace Worker
{
    class Company
    {
        public string CompanyName { get; }
        private Worker[] workers;
        private int stateSize = 5;
        private int currentSize = 0;

        public Company(string companyName)
        {
            CompanyName = companyName;
            workers = new Worker[0];
        }

        public void AddWorker()
        {
            if (currentSize == stateSize)
            {
                throw new FullStateException();
            }

            Console.WriteLine("Enter the FIO: ");
            var fio = Console.ReadLine();

            Console.WriteLine("Enter the position: ");
            var position = Console.ReadLine();

            Console.WriteLine("Enter the year of joining: ");
            var yearOfJoining = Convert.ToInt32(Console.ReadLine());

            if (yearOfJoining > DateTime.Now.Year || yearOfJoining < 1900)
            {
                throw new IncorrectYearException();
            }

            currentSize++;
            var newWorkers = new Worker[currentSize];
            Array.Copy(workers, newWorkers, currentSize - 1);
            newWorkers[currentSize - 1] = new Worker(fio, position, yearOfJoining);
            
            workers = newWorkers.OrderBy(worker => worker.FIO).ToArray<Worker>();
        }

        public void GetWorkersWithMoreExperienceThanInput(int experience)
        {
            var selectedWorkers = workers.Where(worker => (DateTime.Now.Year - worker.YearOfJoining) > experience);
            
            foreach (var worker in selectedWorkers)
            {
                Console.WriteLine($"FIO: {worker.FIO}, position: {worker.Position},  year of joining: {worker.YearOfJoining}");
            }
        }
    }
}
