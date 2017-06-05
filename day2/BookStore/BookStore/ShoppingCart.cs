using System;
using System.Collections.Generic;

namespace BookStore
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }
        
        public int GetTotalPrice<T>(T[] books) where T : IBook
        {
            return 0;
        }
    }
}