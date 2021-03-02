using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Ship : Vehicle
    {
        public int NumOfPassengers { get; set; }
        public string HomePort { get; set; }

        public Ship(double coordX, double coordY, int price, double speed, int productionYear, int numOfPassengers, string homePort)
            : base(coordX, coordY, price, speed, productionYear)
        {
            NumOfPassengers = numOfPassengers;
            HomePort = homePort;
        }

        public Ship(int price, double speed, int numOfPassengers, string homePort)
            : base(price, speed)
        {
            NumOfPassengers = numOfPassengers;
            HomePort = homePort;
        }
    }
}
