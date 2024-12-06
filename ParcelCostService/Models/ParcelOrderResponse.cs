using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelCostService.Models
{
    public class ParcelOrderResponse
    {
        public List<Product> Products { get; private set; }
        public decimal TotalCost => Products.Sum(p => p.Cost);

        public ParcelOrderResponse()
        {
            this.Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }
    }
}
