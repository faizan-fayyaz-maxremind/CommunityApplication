using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class Shop
{
    public long ShopId { get; set; }

    public long? UserId { get; set; }

    public string? ShopName { get; set; }

    public string? Description { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? LogoUrl { get; set; }

    public bool? IsApproved { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual User? User { get; set; }
}
