using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Material : ICloneable
    {
        public string Walls { get; set; }
        public string Roof { get; set; }

        public Material(string walls, string roof)
        {
            Walls = walls;
            Roof = roof;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Walls: {Walls} Roof: {Roof}";
        }
    }
}
