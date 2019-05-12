using System;
using System.Collections.Generic;

namespace StoreInterface
{
    public class InventoryRetailStore : IStore
    {
        List<Product> products;

        double revenue = 0;

        public void GetInventory()
        {
            Console.WriteLine("Store Inventory:");
            foreach (Product t in products)
            {
                Console.WriteLine($"Product name: {t.Name}, id: {t.Id}");
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
            if(products.Remove(product)) //Check for stock availability in inventory
            {
                revenue += product.PriceWhenSell;
            }
            else
            {
                Console.WriteLine("No stock");
            }
            
        }

        public double GetRevenue()
        {
            Console.Write("Inventory store revenue: "); //optional
            return revenue;
        }


    }
}
