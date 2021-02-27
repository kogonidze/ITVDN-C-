using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Point
    {
        public int coordX { get; }

        public int coordY { get; }

        public string Name { get; }

        public Point()
        {
            coordX = 0;
            coordY = 0;
            Name = "Point";
        }

        public Point(string name, int x, int y): this(x, y)
        {
            Name = name;
        }

        public Point(int x, int y)
        {
            coordX = x;
            coordY = y;
            Name = "Point";
        }

        public Point(string name)
        {
            Name = name;
            coordX = 0;
            coordY = 0;
        }
    }
}
