

using ParcelCostService.Models;

namespace ParcelCostService.Tests
{
    public class CreateOrderTests : IClassFixture<ParcelCostServiceEntryFixture>
    {
        private readonly ParcelCostServiceEntryFixture _fixture;

        public CreateOrderTests(ParcelCostServiceEntryFixture fixture)
        {
            _fixture = new ParcelCostServiceEntryFixture();
        }

        [Fact]
        public void CreateOrder_ShouldThrowExceptionGivenNoParcels()
        {
            var request = new ParcelOrderRequest(new List<Parcel>());
            Assert.Throws<ArgumentException>(() =>this._fixture.ParcelCostServiceEntry.CreateOrder(request));
        }

        [Fact]
        public void CreateOrder_ShouldNotReturnEmptyListInResponse()
        {
            var request = new ParcelOrderRequest(new List<Parcel>()
            {
                new Parcel()
                {
                    Size = 10
                }
            });

            var actual = this._fixture.ParcelCostServiceEntry.CreateOrder(request);

            Assert.NotEmpty(actual.Products);
        }
    }
}