using MerchantApi.Data;
using MerchantApi.Interface;

namespace MerchantApi.Services
{
    public class ProductServices
    {
        private IProductOperation _productOperation;

        public ProductServices() 
        {
            _productOperation = new ProductOperation();
        }

        public ProductServices(IProductOperation productOperation)
        {
            this._productOperation = productOperation;
        }

        public int GetProductsTotalCost(string[] productIds)
        {
            return _productOperation.GetProductsTotalCost(productIds);
        }

        public int GetProductsTotalRevenue(string[] productIds)
        {
            return _productOperation.GetProductsTotalRevenue(productIds);
        }
    }
}
