namespace CommunityApplication.DTO
{
    public class AnnouncementDto
    {
        public long AnnouncementId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public long? CreatedByUserId { get; set; }
        public DateTime? CreatedDate { get; set; } = default(DateTime?);
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; } = default(DateTime?);
    }
}
