using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class OrderGood
{
    public int OrderGoodsId { get; set; }

    public int StockId { get; set; }

    public int Amount { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Stock Stock { get; set; } = null!;
}
