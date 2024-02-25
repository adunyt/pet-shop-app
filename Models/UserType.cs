﻿using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class UserType
{
    public int EmployeeTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
