using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public double CoordX { get; set; } = 0.0;
        public double CoordY { get; set; } = 0.0;
        public int Price { get; set; }
        public double Speed { get; set; }
        public int ProductionYear { get; set; } = 2021;

        public Vehicle(double coordX, double coordY, int price, double speed, int productionYear)
        {
            CoordX = coordX;
            CoordY = coordY;
            Price = price;
            Speed = speed;
            ProductionYear = productionYear;
        }

        public Vehicle(int price, double speed)
        {
            Price = price;
            Speed = speed;
        }
    }
}
