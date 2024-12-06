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

            var responseObject = new ParcelOrderResponse();

            foreach (var parcel in request.Parcels)
            {
                var type = "Small";
                var cost = 10;
                var product = new Product(type, cost);
                responseObject.AddProduct(product);
            }

            return responseObject;
        }
    }
}
