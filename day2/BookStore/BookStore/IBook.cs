namespace BookStore
{
    public interface IBook
    {
        string Name { get; }
        int Episode { get; }
        int Price { get; }
        int Quantity { get; }
    }
}