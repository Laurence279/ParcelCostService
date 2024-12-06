

using ParcelCostService.Models;

namespace ParcelCostService.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_NegativeCost_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Product(ParcelType.Small, -10));
        }
    }
}