using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class UserType
{
    public int EmployeeTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
