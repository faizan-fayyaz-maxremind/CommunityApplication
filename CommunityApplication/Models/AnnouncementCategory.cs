using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class AnnouncementCategory
{
    public long CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Announcement> Announcements { get; set; } = new List<Announcement>();
}
