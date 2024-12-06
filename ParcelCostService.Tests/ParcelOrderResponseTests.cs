

using ParcelCostService.Models;

namespace ParcelCostService.Tests
{
    public class ParcelResponseTests
    {

        [Fact]
        public void ParcelOrderResponse_TotalCostShouldBe0OrHigher()
        {
            var product = new Product("Small", 0);

            var response = new ParcelOrderResponse();
            response.AddProduct(product);

            Assert.True(response.TotalCost >= 0);
        }

        [Fact]
        public void ParcelOrderResponse_TotalCostShouldSumProducts()
        {
            var product1 = new Product("Small", 10);
            var product2 = new Product("Small", 20);

            var response = new ParcelOrderResponse();
            response.AddProduct(product1);
            response.AddProduct(product2);

            Assert.True(response.TotalCost == 30);
        }
    }
}