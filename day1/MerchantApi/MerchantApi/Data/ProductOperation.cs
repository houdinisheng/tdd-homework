using MerchantApi.Interface;
using MerchantApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MerchantApi.Data
{
    public class ProductOperation : IProductOperation
    {
        int[] IProductOperation.GetProductsTotalCost(IList<Product> products, int groupCount)
        {
            var groups = GetGroupProducts(products, groupCount);
            return groups.GroupBy(g => g.Group, g => g.Product.Cost).Select(g => g.Sum()).ToArray();
        }

        int[] IProductOperation.GetProductsTotalRevenue(IList<Product> products, int groupCount)
        {
            var groups = GetGroupProducts(products, groupCount);
            return groups.GroupBy(g => g.Group, g => g.Product.Revenue).Select(g => g.Sum()).ToArray();
        }

        private IList<GroupData> GetGroupProducts(IList<Product> products, int groupCount)
        {
            var length = products.Count;
            var groupNumber = (length % groupCount > 0) ? (length / groupCount) + 1 : length / groupCount;
            var groupList = new List<GroupData>();

            for (var i = 0; i < groupNumber; i++)
            {
                var items = products.Skip(i * groupCount)
                                    .Take(groupCount)
                                    .Select(p => new GroupData
                                    {
                                        Group = i + 1,
                                        Product = p
                                    });
                groupList.AddRange(items);
            }

            return groupList;
        }

        private class GroupData
        {
            public int Group { get; set; }

            public Product Product { get; set; }
        }
    }
}
