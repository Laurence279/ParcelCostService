namespace ParcelCostService.Models
{
    public class ParcelProduct : BaseProduct
    {
        public ParcelType Type { get; private set; }

        public ParcelProduct(ParcelType type, decimal cost)
            : base(cost)
        {
            this.Type = type;
            this.Name = type.ToString();
        }
    }
}
