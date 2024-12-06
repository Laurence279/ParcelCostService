using ParcelCostService.Core;

namespace ParcelCostService.Tests
{
    public class ParcelCostServiceEntryFixture
    {
        public ParcelCostServiceEntry ParcelCostServiceEntry { get; private set; }

        public ParcelCostServiceEntryFixture()
        {
            this.ParcelCostServiceEntry = new ParcelCostServiceEntry();
        }
    }
}
