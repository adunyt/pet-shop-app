using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class ShipmentGood
{
    public int ShipmentGoodId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public virtual ShipmentGoodList? ShipmentGoodList { get; set; }
}
