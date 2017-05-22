using MerchantApi.Models;
using System.Collections.Generic;

namespace MerchantApi.Interface
{
    public interface IProductOperation
    {
        int[] GetProductsTotalCost(IList<Product> products, int groupCount);

        int[] GetProductsTotalRevenue(IList<Product> products, int groupCount);
    }
}
