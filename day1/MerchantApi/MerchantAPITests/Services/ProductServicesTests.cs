using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using MerchantApi.Interface;

namespace MerchantApi.Services.Tests
{
    [TestClass()]
    public class ProductServicesTests
    {
        private readonly IProductOperation _operation;

        public ProductServicesTests()
        {
            this._operation= Substitute.For<IProductOperation>();
        }

        [DataTestMethod()]
        [DataRow("1,2,3", 6)]
        [DataRow("4,5,6", 15)]
        [DataRow("7,8,9", 24)]
        [DataRow("10,11", 21)]
        public void Can_Get_Products_Total_Cost(string ids, int expected)
        {
            string[] productIds = GetProductIds(ids);
            _operation.GetProductsTotalCost(productIds).Returns(expected);

            var target = new ProductServices(_operation);
            var actual = target.GetProductsTotalCost(productIds);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow("1,2,3,4", 50)]
        [DataRow("5,6,7,8", 66)]
        [DataRow("9,10,11", 60)]
        public void Can_Get_Products_Total_Revenue(string ids, int expected)
        {
            var productIds = GetProductIds(ids);
            _operation.GetProductsTotalRevenue(productIds).Returns(expected);

            var target = new ProductServices(_operation);
            var actual = target.GetProductsTotalRevenue(productIds);

            Assert.AreEqual(expected, actual);
        }
        
        private static string[] GetProductIds(string ids)
        {
            return ids.Split(',');
        }

    }
}