using System;
using System.Collections.Generic;

namespace PetShop.Models
{
    public partial class GoodType
    {
        public GoodType()
        {
            Goods = new HashSet<Good>();
        }

        public int GoodTypeId { get; set; }
        public string Type { get; set; } = null!;

        public virtual ICollection<Good> Goods { get; set; }
    }
}
