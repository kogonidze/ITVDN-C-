using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    struct Notebook
    {
        private string manufacturer;
        private string model;
        private double price;

        public string Manufacturer
        {
            get { return manufacturer; }
        }

        public string Model 
        { 
            get { return model; } 
        }

        public double Price
        {
            get { return price; }
        }

        public Notebook(string manufacturer, string model, double price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
        }

        public Notebook(string manufacturer, string model) : this(manufacturer, model, 1000)
        {

        }

        public void Show()
        {
            Console.WriteLine($"Notebook: {manufacturer}-{model} Price: {price}");
        }
    }
}
