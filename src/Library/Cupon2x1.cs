using System;
using System.Collections.Generic;

namespace Ucu.Poo.eCommerce
{
    public class Cupon2x1 : IDiscount
    {
        public Cupon2x1()
        {
            
        }
        
        public double GetDiscount(ShoppingCart shoppingCart)
        {
            foreach (var cartItem in shoppingCart.Items)
            {
                
            }
        }
    }
}