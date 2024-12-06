using ParcelCostService.Models;

namespace ParcelCostService.Services
{
    public interface IPricingService
    {
        public decimal GetCost(ParcelType parcelType);
    }
}
