using System;
using System.Collections.Generic;

namespace PetShop.Models
{
    public partial class User
    {
        public User()
        {
            OrderClients = new HashSet<Order>();
            OrderEmployees = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string? Login { get; set; }
        public string? PasswordHash { get; set; }
        public string? Patronymic { get; set; }

        public virtual UserType UserType { get; set; } = null!;
        public virtual ICollection<Order> OrderClients { get; set; }
        public virtual ICollection<Order> OrderEmployees { get; set; }
    }
}
