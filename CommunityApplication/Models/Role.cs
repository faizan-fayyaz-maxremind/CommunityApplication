using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class Role
{
    public long RoleId { get; set; }

    public string? RoleName { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
