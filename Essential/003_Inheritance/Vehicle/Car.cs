using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car : Vehicle
    {
        public Car(double coordX, double coordY, int price, double speed, int productionYear)
            : base(coordX, coordY, price, speed, productionYear)
        {

        }

        public Car(int price, double speed)
            :base(price, speed)
        {

        }
    }
}
