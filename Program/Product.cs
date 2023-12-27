using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Product
    {
        public string Name { get; set; }

        public float Price { get; set; }
        public Currency Cost { get; set; }
        public ushort Quantity { get; set; }
        public string Producer { get; set; }
        public float Weight { get; set; }

        public Product(string name, float price, Currency cost, ushort quantity, string producer, float weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(float price, Currency cost, ushort quantity, string producer, float weight)
        {
            Name = "Кавоварка";
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product() {
            Name = "Сертифікат від магазину";
            Price = 10;
            Cost = new Currency();
            Quantity = 1000;
            Producer = "Shop";
            Weight = 0;
        }

        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = obj.Cost;
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;

        }
        public float GetPriceInUAH()
        {
            if(Cost.Name != "UAH") 
            return Price * Cost.ExRate;
            return Price;
        }
        public float GetTotalPriceInUAH()
        {
            return Quantity * GetPriceInUAH();
        }

        public float GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
