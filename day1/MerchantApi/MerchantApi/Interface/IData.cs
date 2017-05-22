using MerchantApi.Models;
using System.Collections.Generic;

namespace MerchantApi.Interface
{
    public interface IData
    {
        IList<Product> Products { get; }
    }
}
