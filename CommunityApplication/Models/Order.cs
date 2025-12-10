using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class Order
{
    public long OrderId { get; set; }

    public long? UserId { get; set; }

    public long? ShopId { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Status { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Shop? Shop { get; set; }

    public virtual User? User { get; set; }
}
