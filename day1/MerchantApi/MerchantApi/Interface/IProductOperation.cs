namespace MerchantApi.Interface
{
    public interface IProductOperation
    {
        int GetProductsTotalCost(string[] productIds);

        int GetProductsTotalRevenue(string[] productIds);
    }
}
