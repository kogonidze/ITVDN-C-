using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCollection
{
    class Bus : BaseCar
    {
        public int NumberOfSeats { get; set; }

        public Bus(string name, int yearOfProduction, int numberOfSeats)
            : base(name, yearOfProduction)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
