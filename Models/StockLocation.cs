using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class StockLocation
{
    public int StockLocationId { get; set; }

    public int PalleteNumber { get; set; }

    public int ShelfNumber { get; set; }

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
