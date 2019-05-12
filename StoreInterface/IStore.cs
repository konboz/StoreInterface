using System;
using System.Collections.Generic;
using System.Text;

namespace StoreInterface
{
    public interface IStore
    {
        void Buy(Product product);

        void Sell(Product product);

        double GetRevenue();
    }
}
