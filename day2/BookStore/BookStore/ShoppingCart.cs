using BookStore.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BookStore
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        public decimal GetTotalPrice<T>(T[] books) where T : IBook
        {
            var quanties = books.Select(b => b.Quantity).ToArray();
            var levels = new List<int>();
            GetDiscountLevels(levels, quanties);
            return GetTotalPrice(books, levels);
        }

        private decimal GetTotalPrice<T>(T[] books, List<int> levels) where T : IBook
        {
            var total = 0m;
            foreach (var level in levels)
            {
                var discount = GetDiscount(level);
                for (var i = 0; i < books.Length; i++)
                {
                    var book = books[i];
                    if (book.Quantity > 0)
                    {
                        total += book.Price * discount;
                        book.Quantity -= 1;
                    }
                }
            }

            return total;
        }

        private decimal GetDiscount(int level)
        {
            decimal discount;
            switch (level)
            {
                case 1:
                    discount = 0.95m;
                    break;

                case 2:
                    discount = 0.9m;
                    break;

                case 3:
                    discount = 0.8m;
                    break;

                case 4:
                    discount = 0.75m;
                    break;

                default:
                    discount = 1;
                    break;
            }
            return discount;
        }

        private void GetDiscountLevels(List<int> levels, int[] quanties)
        {
            var level = 0;
            for (var i = 0; i < quanties.Length; i++)
            {
                var qty = quanties[i];
                
                if (qty > 1)
                {
                    level++;
                }
                
                quanties[i] -= 1;
            }

            levels.Add(level);
            if (quanties.Any(q => q > 0))
            {
                GetDiscountLevels(levels, quanties);
            }
        }
    }
}