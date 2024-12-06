using System.ComponentModel.DataAnnotations;

namespace ParcelCostService.Models
{
    public class Product
    {
        public string Type { get; private set; }
        public decimal Cost { get; private set; }

        public Product(string type, decimal cost)
        {
            if (cost < 0) throw new ArgumentException("Cost should not be less than zero.");
            this.Type = type;
            this.Cost = cost;
        }
    }
}
