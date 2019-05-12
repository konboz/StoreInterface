using System;
using System.Collections.Generic;
using System.Text;

namespace StoreInterface
{
    public class InventoryRetailStore : IStore
    {
        List<Product> products;

        double revenue=0;
    
        public void GetInventory()
        {
            foreach (Product t in products)
            {
                Console.WriteLine(t.Name);
            }
        }

        public void Reset()
        {
            products = new List<Product>();
        }

        public InventoryRetailStore()
        {
            products = new List<Product>();
        }

        public void Buy(Product product)
        {
            products.Add(product);
            revenue -= product.PriceWhenBuy;
            
        }

        public void Sell(Product product)
        {
            products.Remove(product);
            revenue += product.PriceWhenSell;
        }

        public double GetRevenue()
        {
            return revenue;
        }
        

    }
}
