using System;
using System.Collections.Generic;

namespace CommunityApplication.Models;

public partial class Announcement
{
    public long AnnouncementId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public long? CategoryId { get; set; }

    public string? ImageUrl { get; set; }

    public bool? IsPublished { get; set; }

    public long? CreatedByUserId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual AnnouncementCategory? Category { get; set; }

    public virtual User? CreatedByUser { get; set; }
}
