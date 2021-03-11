using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCollection
{
    class BaseCar
    {
        public string Name { get; set; }
        public int YearOfProduction { get; set; }

        public BaseCar(string name, int yearOfProduction)
        {
            Name = name;
            YearOfProduction = yearOfProduction;
        }
    }
}
