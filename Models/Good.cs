using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class Good
{
    public int GoodId { get; set; }

    public string Name { get; set; } = null!;

    public int PriceId { get; set; }

    public int GoodTypeId { get; set; }

    public virtual GoodType GoodType { get; set; } = null!;

    public virtual Price Price { get; set; } = null!;

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
