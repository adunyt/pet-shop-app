using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class Price
{
    public int PriceId { get; set; }

    public decimal Value { get; set; }

    public DateTime DateSet { get; set; }

    public DateTime? DateUnset { get; set; }

    public virtual ICollection<Good> Goods { get; set; } = new List<Good>();
}
