using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Plane : Vehicle
    {
        public double Height { get; set; }
        public int NumberOfPassengers { get; set; }

        public Plane(double coordX, double coordY, int price, double speed, int productionYear,
            double height, int numberOfPassengers) : base(coordX, coordY, price, speed, productionYear)
        {
            Height = height;
            NumberOfPassengers = numberOfPassengers;
        }

        public Plane(int price, double speed, double height, int numberOfPassengers)
            :base(price, speed)
        {
            Height = height;
            NumberOfPassengers = numberOfPassengers;
        }
    }
}
