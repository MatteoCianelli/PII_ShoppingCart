using System.Collections.Generic;
using System.Security.AccessControl;

namespace Ucu.Poo.eCommerce
{
    public class CuponDiscount : IDiscount
    {
        public int DiscountPercent { get; set; }

        public CuponDiscount(int discountPercent)
        {
            this.DiscountPercent = discountPercent / 100;
        }
        
        public double GetDiscount(ShoppingCart shoppingCart)
        {
            return shoppingCart.GetTotal() - shoppingCart.GetTotal() * DiscountPercent;
        }
    }
}