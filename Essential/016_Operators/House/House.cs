using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        private Material material;
        private int price;

        public Material Material
        {
            get { return material; }
            set { material = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public House(Material material, int price)
        {
            this.material = material;
            this.price = price;
        }

        public House Clone()
        {
            return this;
        }

        public House DeepClone()
        {
            return new House(this.Material.Clone() as Material, this.price);
        }

        public override string ToString()
        {
            return $"Materials: {Material} Price: {Price}";
        }
    }
}
