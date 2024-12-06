using System.ComponentModel;
using System.Runtime.CompilerServices;
using ParcelCostService.Models;
using ParcelCostService.Services;

namespace ParcelCostService.Core
{
    public class ParcelCostServiceEntry
    {
        private readonly IPricingService _pricingService;

        public ParcelCostServiceEntry(IPricingService pricingService)
        {
            _pricingService = pricingService;
        }

        public ParcelOrderResponse CreateOrder(ParcelOrderRequest request)
        {
            if (!request.Parcels.Any())
            {
                throw new ArgumentException("Order must have at least one parcel.");
            }
            if (request.Parcels.Any(x => x.Size <= 0 || double.IsNaN(x.Size)))
            {
                throw new ArgumentException("Parcel size should be more than zero and a number.");
            }

            var responseObject = new ParcelOrderResponse();

            foreach (var parcel in request.Parcels)
            {
                var type = GetParcelType(parcel);
                var cost = GetParcelCost(type);
                var product = new Product(type, cost);
                responseObject.AddProduct(product);
            }

            return responseObject;
        }

        private static ParcelType GetParcelType(Parcel parcel)
        {
            var type = parcel.Size switch
            {
                < 10 => ParcelType.Small,
                <= 50 => ParcelType.Medium,
                < 100 => ParcelType.Large,
                >= 100 => ParcelType.XLarge,
                _ => throw new ArgumentException($"Invalid size given: {parcel.Size}")
            };
            return type;
        }

        private decimal GetParcelCost(ParcelType type)
        {
            return _pricingService.GetCost(type);
        }
    }
}
