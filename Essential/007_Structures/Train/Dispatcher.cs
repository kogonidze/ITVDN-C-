using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Dispatcher
    {
        private Train[] trains;

        public Dispatcher()
        {
            trains = new Train[8];
        }

        public string this[int numberTrain]
        {
            get
            {
                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].NumberTrain == numberTrain)
                    {
                        return $"Destination: {trains[i].Destination}, Number of train: {trains[i].NumberTrain}, " +
                            $"Departure time: {trains[i].DepartureTime}";
                    }
                }

                return "There is no train with such number!";
            }
        }

        public Train[] InitializeTrains()
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Enter the destination of train: ");
                var destination = Console.ReadLine();

                Console.WriteLine("Enter the number of train: ");
                var trainNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the departure time of train: ");
                var departureTime = TimeSpan.Parse(Console.ReadLine());

                trains[i] = new Train(destination, trainNumber, departureTime);
            }

            trains = OrderByAscTrains();

            return trains;
        }

        public Train[] OrderByAscTrains()
        {
            for (int i = trains.Length - 1; i >= 0; i--)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if (trains[j].NumberTrain > trains[i].NumberTrain)
                    {
                        var temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }

            return trains;
        }

    }
}
