using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public Color Color { get; set; }

        public Car(string make, string model, int yearOfProduction, Color color)
        {
            Make = make;
            Model = model;
            YearOfProduction = yearOfProduction;
            Color = color;
        }
    }
}
