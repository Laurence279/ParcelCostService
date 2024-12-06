using ParcelCostService.Models;

namespace ParcelCostService.Services
{
    public class StandardPricingService : IPricingService
    {
        private readonly Dictionary<ParcelType, decimal> _priceDictionary;

        public StandardPricingService()
        {
            _priceDictionary = new Dictionary<ParcelType, decimal>();
            AddPrices();
        }

        private void AddPrices()
        {
            _priceDictionary[ParcelType.Small] = 3;
            _priceDictionary[ParcelType.Medium] = 8;
            _priceDictionary[ParcelType.Large] = 15;
            _priceDictionary[ParcelType.XLarge] = 25;
        }

        public decimal GetCost(ParcelType parcelType)
        {
            return _priceDictionary[parcelType];
        }
    }
}
