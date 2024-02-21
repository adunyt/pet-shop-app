using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int EmployeeId { get; set; }

    public int ClientId { get; set; }

    public int OrderGoodsId { get; set; }

    public DateTime Time { get; set; }

    public virtual User Client { get; set; } = null!;

    public virtual User Employee { get; set; } = null!;

    public virtual OrderGood OrderGoods { get; set; } = null!;
}
