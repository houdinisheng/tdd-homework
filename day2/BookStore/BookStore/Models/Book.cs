using BookStore.Interfaces;

namespace BookStore.Models
{
    public class Book : IBook
    {
        private string name;
        private int qty;
        private int episode;
        private int price;

        public Book(string name, int episode, int price, int qty)
        {
            this.name = name;
            this.episode = episode;
            this.price = price;
            this.qty = qty;
        }

        int IBook.Episode
        {
            get { return episode; }
        }

        string IBook.Name
        {
            get { return name; }
        }

        decimal IBook.Price
        {
            get { return price; }
        }

        int IBook.Quantity
        {
            get { return qty; }
            set { qty = value; }
        }
    }
}