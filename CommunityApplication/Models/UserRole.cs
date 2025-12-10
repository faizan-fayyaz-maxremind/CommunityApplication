using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class UserRole
{
    public long UserRoleId { get; set; }

    public long? UserId { get; set; }

    public long? RoleId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
