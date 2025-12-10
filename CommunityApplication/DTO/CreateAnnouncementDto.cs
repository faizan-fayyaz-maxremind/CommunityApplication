namespace CommunityApplication.DTO
{
    public class CreateAnnouncementDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public long? CreatedByUserId { get; set; }
        public DateTime? CreatedDate { get; set; } = default(DateTime?);
    }
}
