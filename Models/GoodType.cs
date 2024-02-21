using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class GoodType
{
    public int GoodTypeId { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Good> Goods { get; set; } = new List<Good>();
}
