using System;
using System.Collections.Generic;

namespace PetShop.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderGoods = new HashSet<OrderGood>();
        }

        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public DateTime Time { get; set; }

        public virtual User Client { get; set; } = null!;
        public virtual User Employee { get; set; } = null!;
        public virtual ICollection<OrderGood> OrderGoods { get; set; }
    }
}
