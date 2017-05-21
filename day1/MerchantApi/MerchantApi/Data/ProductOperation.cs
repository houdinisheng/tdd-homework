using MerchantApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantApi.Data
{
    public class ProductOperation : IProductOperation
    {
        int IProductOperation.GetProductsTotalCost(string[] productIds)
        {
            return ProductData.List.Where(kvp => productIds.Contains(kvp.Key)).Sum(kvp => kvp.Value.Cost);
        }

        int IProductOperation.GetProductsTotalRevenue(string[] productIds)
        {
            return ProductData.List.Where(kvp => productIds.Contains(kvp.Key)).Sum(kvp => kvp.Value.Revenue);
        }
    }
}
