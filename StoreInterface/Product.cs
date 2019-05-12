using System;
using System.Collections.Generic;
using System.Text;

namespace StoreInterface
{
     public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PriceWhenBuy { get; set; }
        public double PriceWhenSell { get; set; }

        public Product(int id, string name, double priceWhenBuy, double priceWhenSell)
        {
            Id = id;
            Name = name;
            PriceWhenBuy = priceWhenBuy;
            PriceWhenSell = priceWhenSell;
        }
    }
}
