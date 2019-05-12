using System;
using System.Collections.Generic;
using System.Text;

namespace StoreInterface
{
    class InventoryRetailStore : IStore
    {
        List<Product> products;

        double revenue=0;
        double expenses = 0;
        double income = 0;

        public List<Product> GetInventory()
        {
            return products;
        }

        public InventoryRetailStore(List<Product> products)
        {
            this.products = new List<Product>();
        }

        public void Reset()
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
            revenue += product.PriceWhenSell
        }

        public double GetRevenue()
        {
            throw new NotImplementedException();
        }
    }
}
