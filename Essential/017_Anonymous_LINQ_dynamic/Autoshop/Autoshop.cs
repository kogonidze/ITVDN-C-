using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop
{
    class Autoshop
    {
        public List<Car> cars { get; }
        public List<Customer> customers { get; }

        public Autoshop()
        {
            cars = new List<Car>
            {
                new Car("Audi", "A4", 2019, Color.Black),
                new Car("BMW", "X5", 2020, Color.Red),
                new Car("Dodge", "Caravan", 1998, Color.Blue),
                new Car("Renaught", "Logan", 2018, Color.White),
                new Car("Volkswaggen", "Polo", 2018, Color.Green),
                new Car("Toyota", "Camry", 2020, Color.White),
                new Car("Lada", "Vesta", 2019, Color.Blue),
                new Car("Lada", "Granta", 2020, Color.Gray),
                new Car("Bentley", "Continental", 2020, Color.Black),
                new Car("Toyota", "RAV4", 2015, Color.White)
            };

            customers = new List<Customer>
            {
                new Customer("V.Andreev", "43434343", "Vesta"),
                new Customer("A.Petrov", "32322342", "Granta"),
                new Customer("N.Sobolev", "44343523", "Camry"),
                new Customer("A.Sysoev", "43543532", "Logan"),
                new Customer("S.Sergeev", "43434312", "X5"),
                new Customer("V.Suvorov", "4234343", "A4"),
                new Customer("S.Sidorov", "3221112", "Continental"),
                new Customer("A.Dudoev", "323324224", "Logan")
            };
        }
    }
}
