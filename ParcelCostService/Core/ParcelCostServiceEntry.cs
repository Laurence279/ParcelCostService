using ParcelCostService.Models;

namespace ParcelCostService.Core
{
    public class ParcelCostServiceEntry
    {
        public ParcelCostServiceEntry()
        {

        }

        public ParcelOrderResponse CreateOrder(ParcelOrderRequest request)
        {
            if (!request.Parcels.Any())
            {
                throw new ArgumentException("Order must have at least one parcel.");
            }

            var products = new List<Product>()
            {
                new Product("ParcelA", 10)
            };

            return new ParcelOrderResponse(products);
        }
    }
}
