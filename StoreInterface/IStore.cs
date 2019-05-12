using System;

namespace StoreInterface
{
    public interface IStore
    {
        void Buy(Product product);

        void Sell(Product product);

        double GetRevenue();
    }
}
