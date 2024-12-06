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

        public ParcelOrderResponse(List<Product> products)
        {
            if (products == null) throw new ArgumentNullException(nameof(products));
            this.Products = products;
        }
    }
}
