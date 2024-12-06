using ParcelCostService.Models;

namespace ParcelCostService.Services
{
    public interface IPricingService
    {
        public decimal GetParcelCost(ParcelType parcelType);

        public decimal GetSpeedyCheckoutCost(List<BaseProduct> products);
    }
}
