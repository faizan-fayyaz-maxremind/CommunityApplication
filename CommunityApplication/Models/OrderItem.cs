using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class OrderItem
{
    public long OrderItemId { get; set; }

    public long? OrderId { get; set; }

    public long? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
