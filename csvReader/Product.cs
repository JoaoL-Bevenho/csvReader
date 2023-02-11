using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvReader
{
    public class Product
    {

        private string name;
        private string price;
        private string brand;
        private string weight;


        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Weight { get => weight; set => weight = value; }


        public Product()
        {
            this.name = Name;
            this.price = Price;
            this.brand = Brand;
            this.weight = Weight;
        }
    }
}
