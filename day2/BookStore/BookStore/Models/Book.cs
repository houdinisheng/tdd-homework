using System;

namespace BookStore.Models
{
    public class Book : IBook
    {
        private string bookName;
        private int episode;
        private int price;
        private int qty;

        public Book(string bookName, int episode, int price, int qty)
        {
            this.bookName = bookName;
            this.episode = episode;
            this.price = price;
            this.qty = qty;
        }

        int IBook.Episode
        {
            get
            {
                return episode;
            }
        }

        string IBook.Name
        {
            get
            {
                return bookName;
            }
        }

        int IBook.Price
        {
            get
            {
                return price;
            }
        }

        int IBook.Quantity
        {
            get
            {
                return qty;
            }
        }
    }
}