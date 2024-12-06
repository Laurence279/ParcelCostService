namespace ParcelCostService.Models
{
    public class BaseProduct
    {
        public string Name { get; set; }
        public decimal Cost { get; private set; }

        public BaseProduct(decimal cost, string name = "Product")
        {
            this.Name = name;
            if (cost < 0) throw new ArgumentException("Cost should not be less than zero.");
            Cost = cost;
        }
    }
}
