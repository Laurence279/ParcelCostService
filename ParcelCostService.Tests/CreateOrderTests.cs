

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

        [Fact]
        public void CreateOrder_Given3Parcels_ShouldReturnListWith3Items()
        {
            var request = new ParcelOrderRequest(new List<Parcel>()
            {
                new Parcel()
                {
                    Size = 10
                },
                new Parcel()
                {
                    Size = 60
                },
                new Parcel()
                {
                    Size = 150
                }
            });

            var expected = 3;

            var actual = this._fixture.ParcelCostServiceEntry.CreateOrder(request);

            Assert.Equal(expected, actual.Products.Count);
        }

        [Fact]
        public void CreateOrder_SpeedyCheckoutSelectedWith4Parcels_ShouldReturnListWith5Items()
        {
            var parcels = new List<Parcel>()
            {
                new Parcel()
                {
                    Size = 20
                },
                new Parcel()
                {
                    Size = 30
                },
                new Parcel()
                {
                    Size = 100
                }
            };

            var request = new ParcelOrderRequest(parcels)
            {
                SpeedyCheckout = true
            };

            var expected = 4;

            var actual = this._fixture.ParcelCostServiceEntry.CreateOrder(request);

            Assert.Equal(expected, actual.Products.Count);
        }


        [Fact]
        public void CreateOrder_SpeedyCheckoutSelectedWithStandardPricing_ShouldDoubleCostOfParcels()
        {
            var parcels = new List<Parcel>()
            {
                new Parcel()
                {
                    Size = 20
                },
                new Parcel()
                {
                    Size = 15
                }
            };

            var request = new ParcelOrderRequest(parcels)
            {
                SpeedyCheckout = true
            };

            var response = this._fixture.ParcelCostServiceEntry.CreateOrder(request);
            var expectedTotal = 32;

            Assert.Equal(expectedTotal, response.TotalCost);
        }
    }
}