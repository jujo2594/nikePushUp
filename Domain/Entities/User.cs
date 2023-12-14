using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class User : BaseEntity
{

    public string Username { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public virtual ICollection<Rol> IdRolFks { get; set; } = new List<Rol>();
}
