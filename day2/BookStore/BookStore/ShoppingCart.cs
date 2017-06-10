using BookStore.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BookStore
{
    public class ShoppingCart
    {
        private readonly Dictionary<int, decimal> _discount;

        public ShoppingCart()
        {
            _discount = new Dictionary < int, decimal>
            {
                { 2, 0.95m },
                { 3, 0.9m },
                { 4, 0.8m  },
                {5,0.75m }
            };
        }

        public decimal GetTotalPrice<T>(T[] books) where T : IBook
        {
            var quantities = (from b in books
                              group b by b.Episode into g
                              select g.Sum(b => b.Quantity)).ToArray();

            var levels = GetDiscountLevels(quantities);
            return GetTotalPrice(books, levels);
        }

        private decimal GetTotalPrice<T>(T[] books, List<int> levels) where T : IBook
        {
            var total = 0m;
            foreach (var level in levels)
            {
                var discount = GetDiscount(level);
                var bookCount = 0;
                for (var i = 0; i < books.Length; i++)
                {
                    var book = books[i];
                    if (book.Quantity > 0)
                    {
                        ++bookCount;
                        var price = (bookCount <= level) ? book.Price* discount : book.Price;
                        total += price;
                        book.Quantity -= 1;

                    }
                }
            }

            return total;
        }

        private decimal GetDiscount(int level)
        {
            decimal discount;
            return _discount.TryGetValue(level, out discount) ? discount : 1m;
        }

        private List<int> GetDiscountLevels(int[] quantities)
        {
            var levels = new List<int>();
            while (quantities.Any(q => q > 0))
            {
                var level = 0;
                for (var i = 0; i < quantities.Length; i++)
                {
                    var qty = quantities[i];

                    if (qty >= 1)
                    {
                        level++;
                    }

                    quantities[i] -= 1;
                }

                levels.Add(level);
            }

            return levels;
        }
    }
}