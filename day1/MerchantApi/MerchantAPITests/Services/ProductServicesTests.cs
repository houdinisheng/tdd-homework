using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using MerchantApi.Interface;
using MerchantApi.Data;

namespace MerchantApi.Services.Tests
{
    [TestClass]
    public class ProductServicesTests
    {
        [TestMethod]
        public void Can_Get_Products_Total_Cost()
        {
            var groupCount = 3;
            var expected = new int[] { 6, 15, 24, 21 };
            
            var target = new ProductServices();
            var actual = target.GetProductsTotalCost(groupCount);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Can_Get_Products_Total_Revenue()
        {
            var groupCount = 4;
            var expected = new int[] { 50, 66, 60 };
            
            var target = new ProductServices();
            var actual = target.GetProductsTotalRevenue(groupCount);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}