using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class Provider
{
    public int ProviderId { get; set; }

    public string Name { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<ShipmentGoodList> ShipmentGoodLists { get; set; } = new List<ShipmentGoodList>();
}
