using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCollection
{
    class CarCollection<T> where T : BaseCar
    {
        private T[] CarPark;

        public CarCollection()
        {
            CarPark = new T[0];
        }

        public int Count
        {
            get
            {
                return CarPark.Length;
            }
        }

        public void Add(T newCar)
        {
            var enlargedPark = new T[CarPark.Length + 1];
            Array.Copy(CarPark, enlargedPark, CarPark.Length);

            enlargedPark[CarPark.Length] = newCar;
            CarPark = enlargedPark;
        }

        public string this[int index]
        {
            get
            {
                return $"Car Name: {CarPark[index].Name}, Year of production: {CarPark[index].YearOfProduction}";
            }
        }

        public void Clear()
        {
            CarPark = new T[0];
        }
    }
}
