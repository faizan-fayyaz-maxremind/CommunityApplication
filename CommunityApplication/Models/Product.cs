using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class Product
{
    public long ProductId { get; set; }

    public long? ShopId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public long? CategoryId { get; set; }

    public string? ImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ProductCategory? Category { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Shop? Shop { get; set; }
}
