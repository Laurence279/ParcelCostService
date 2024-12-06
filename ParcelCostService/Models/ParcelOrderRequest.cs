using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelCostService.Models
{
    public class ParcelOrderRequest
    {
        public List<Parcel> Parcels { get; set; }
        public bool SpeedyCheckout { get; set; }
        public ParcelOrderRequest(List<Parcel> parcels)
        {
            this.Parcels = parcels;
        }

    }
}
