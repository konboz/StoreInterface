using System;

namespace StoreInterface
{
    public class SimpleRetailStore : IStore
    {
        public double TotalBuyBalance { get; set; }
        public double TotalSellBalance { get; set; }

        public SimpleRetailStore()
        {
            
        }
        
        public void Buy(Product product)
        {
            TotalBuyBalance+=product.PriceWhenBuy;
        }

        public void Sell(Product product)
        {
            TotalSellBalance += product.PriceWhenSell;
        }

        public double GetRevenue()
        {
            Console.Write("Simple store revenue: "); //optional
            double revenue = TotalSellBalance - TotalBuyBalance;
            return revenue;
        }
    }
}
