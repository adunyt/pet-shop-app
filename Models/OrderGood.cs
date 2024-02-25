using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class OrderGood
{
    public int OrderGoodsId { get; set; }

    public int GoodId { get; set; }

    public int Amount { get; set; }

    public int OrderId { get; set; }

    public virtual Good Good { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
