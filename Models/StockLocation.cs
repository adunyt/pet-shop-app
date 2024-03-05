using System;
using System.Collections.Generic;

namespace PetShop.Models
{
    public partial class StockLocation
    {
        public StockLocation()
        {
            Stocks = new HashSet<Stock>();
        }

        public int StockLocationId { get; set; }
        public string LocationDesc { get; set; } = null!;

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
