namespace ParcelCostService.Models
{
    public class Product
    {
        public string Type { get; private set; }
        public decimal Cost { get; private set; }

        public Product(string type, decimal cost)
        {
            this.Type = type;
            this.Cost = cost;
        }
    }
}
