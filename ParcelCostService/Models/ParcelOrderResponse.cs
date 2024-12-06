using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelCostService.Models
{
    public class ParcelOrderResponse
    {
        public List<BaseProduct> Products { get; set; }
        public decimal TotalCost => Products.Sum(p => p.Cost);

        public ParcelOrderResponse()
        {
            this.Products = new List<BaseProduct>();
        }

        public void AddProduct(BaseProduct product)
        {
            this.Products.Add(product);
        }
    }
}
