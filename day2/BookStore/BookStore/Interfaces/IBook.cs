namespace BookStore.Interfaces
{
    public interface IBook
    {
        string Name { get; }
        int Episode { get; }
        decimal Price { get; }
        int Quantity { get; set; }
    }
}