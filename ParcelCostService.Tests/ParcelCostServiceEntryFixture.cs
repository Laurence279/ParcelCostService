using ParcelCostService.Core;
using ParcelCostService.Models;
using ParcelCostService.Services;

namespace ParcelCostService.Tests
{
    public class ParcelCostServiceEntryFixture
    {
        public ParcelCostServiceEntry ParcelCostServiceEntry { get; private set; }

        public ParcelCostServiceEntryFixture()
        {
            this.ParcelCostServiceEntry = new ParcelCostServiceEntry(new StandardPricingService());
        }
    }
}
