using MerchantApi.Data;
using MerchantApi.Interface;

namespace MerchantApi.Services
{
    public class ProductServices
    {
        private IProductOperation _productOperation;
        private IData _data;

        public ProductServices() 
        {
            _data = new ProductData();
            _productOperation = new ProductOperation();
        }

        public ProductServices(IData data, IProductOperation productOperation)
        {
            this._data = data;
            this._productOperation = productOperation;
        }

        public int[] GetProductsTotalCost(int groupCount)
        {
            return _productOperation.GetProductsTotalCost(_data.Products, groupCount);
        }

        public int[] GetProductsTotalRevenue(int groupCount)
        {
            return _productOperation.GetProductsTotalRevenue(_data.Products, groupCount);
        }
    }
}
