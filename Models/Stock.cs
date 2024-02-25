using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class Stock
{
    public int StockId { get; set; }

    public int Amount { get; set; }

    public int ShipmentGoodsId { get; set; }

    public int GoodId { get; set; }

    public int StockLocationId { get; set; }

    public virtual Good Good { get; set; } = null!;

    public virtual ICollection<OrderGood> OrderGoods { get; set; } = new List<OrderGood>();

    public virtual ShipmentGoodList ShipmentGoods { get; set; } = null!;

    public virtual StockLocation StockLocation { get; set; } = null!;
}
