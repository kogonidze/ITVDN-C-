using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    struct Train
    {
        private string destination;
        private int numberTrain;
        private TimeSpan departureTime;

        public string Destination
        {
            get
            {
                return destination;
            }
        }

        public int NumberTrain
        {
            get
            {
                return numberTrain;
            }
        }

        public TimeSpan DepartureTime
        {
            get
            {
                return departureTime;
            }
        }

        public Train(string destination, int numberTrain, TimeSpan departureTime)
        {
            this.destination = destination;
            this.numberTrain = numberTrain;
            this.departureTime = departureTime;
        }

    }
}
