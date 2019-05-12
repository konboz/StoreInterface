using System;
using System.Collections.Generic;
using System.Text;

namespace StoreInterface
{
    class SimpleRetailStore
    {
        public double TotalBuyBalance { get; set; }
        public double TotalSellBalance { get; set; }

        public SimpleRetailStore(double totalBuyBalance, double totalSellBalance)
        {
            TotalBuyBalance = totalBuyBalance;
            TotalSellBalance = totalSellBalance;
        }
    }
}
