﻿using System;
using System.Collections.Generic;

namespace PetShop.Models
{
    public partial class ShipmentGoodList
    {
        public ShipmentGoodList()
        {
            Stocks = new HashSet<Stock>();
        }

        public int ShipmentGoodsId { get; set; }
        public int ProviderId { get; set; }
        public int ShipmentGoodId { get; set; }
        public DateTime Time { get; set; }

        public virtual Provider Provider { get; set; } = null!;
        public virtual ShipmentGood ShipmentGoods { get; set; } = null!;
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
