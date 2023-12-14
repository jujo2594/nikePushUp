using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Rol : BaseEntity
{

    public string Nombre { get; set; }

    public virtual ICollection<User> IdUserFks { get; set; } = new List<User>();
}
