using System.Collections.Generic;

namespace Ucu.Poo.eCommerce
{
    public interface IDiscount
    {
        double GetDiscount(ShoppingCart shoppingCart);
    }
}