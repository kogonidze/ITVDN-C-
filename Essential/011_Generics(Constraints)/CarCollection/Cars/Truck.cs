using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCollection
{
    class Truck : BaseCar
    {
        public int CarryingCapacity { get; set; }

        public Truck(string name, int yearOfProduction, int carryingCapacity)
            : base(name, yearOfProduction)
        {
            CarryingCapacity = carryingCapacity;
        }
    }
}
