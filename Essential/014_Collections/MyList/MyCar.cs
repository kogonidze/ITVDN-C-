using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyCar
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }

        public MyCar(string vendor, string model, int year)
        {
            Vendor = vendor;
            Model = model;
            YearOfProduction = year;
        }
    }
}
