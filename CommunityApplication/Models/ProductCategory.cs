using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class ProductCategory
{
    public long CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
