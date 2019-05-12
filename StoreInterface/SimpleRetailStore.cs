using System;
using System.Collections.Generic;
using System.Text;

namespace StoreInterface
{
    public class SimpleRetailStore : IStore
    {
        public double TotalBuyBalance { get; set; }
        public double TotalSellBalance { get; set; }

        public SimpleRetailStore()
        {
            
        }
        //public SimpleRetailStore(double totalBuyBalance, double totalSellBalance)
        //{
        //    TotalBuyBalance = totalBuyBalance;
        //    TotalSellBalance = totalSellBalance;
        //}

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
            double revenue = TotalSellBalance - TotalBuyBalance;
            return revenue;
        }
    }
}
