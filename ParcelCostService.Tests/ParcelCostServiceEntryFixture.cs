using ParcelCostService.Core;
using ParcelCostService.Models;
using ParcelCostService.Services;

namespace ParcelCostService.Tests
{
    public class ParcelCostServiceEntryFixture
    {
        public ParcelCostServiceEntry ParcelCostServiceEntry { get; private set; }

        public StandardPricingService PricingService { get; private set; }

        public ParcelCostServiceEntryFixture()
        {
            this.PricingService = new StandardPricingService();
            this.ParcelCostServiceEntry = new ParcelCostServiceEntry(this.PricingService);
        }
    }
}
