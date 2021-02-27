using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Figure
    {
        private Point Point1 { get; set; }
        private Point Point2 { get; set; }
        private Point Point3 { get; set; }
        private Point Point4 { get; set; }
        private Point Point5 { get; set; }

        public string Name { get; set; }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
            : this(point1, point2, point3, point4)
        {
            Point5 = point5;
            Name = "Pentagon";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
            : this(point1, point2, point3)
        {
            Point4 = point4;
            Name = "Rectangle";
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Name = "Triangle";
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.coordX - A.coordX),2) + Math.Pow((B.coordY - A.coordY),2));
        }

        public void PerimeterCalculator()
        {
            var perimeter = 0.0;
            var validPoints = GetValidPoints();

            for (int i = 0; i < validPoints.Count; i++)
            {
                if (i == validPoints.Count - 1)
                {
                    perimeter += LengthSide(validPoints[i], validPoints[0]);
                    break;
                }
                perimeter += LengthSide(validPoints[i], validPoints[i + 1]);
            }

            Console.WriteLine($"Perimeter of Polygon = {perimeter}");
        }

        public List<Point> GetValidPoints()
        {
            var points = new List<Point> { Point1, Point2, Point3, Point4, Point5 };

            return points.Where(point => point != null).ToList();
        }
    }
}
