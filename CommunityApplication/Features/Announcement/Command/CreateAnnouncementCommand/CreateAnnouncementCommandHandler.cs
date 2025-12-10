using CommunityApplication.Models;
using MediatR;
// Ensure the Announcement class is referenced correctly.
// If Announcement is a namespace, you need to use the full type name, e.g., CommunityApplication.Models.Announcement
// If Announcement is not a class, you need to define it or import the correct namespace.

namespace CommunityApplication.Features.Announcement.Command.CreateAnnouncementCommand
{
    public class CreateAnnouncementCommandHandler : IRequestHandler<CreateAnnouncementCommand, long>
    {
        private readonly ApplicationDbContext _context;

        public CreateAnnouncementCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<long> Handle(CreateAnnouncementCommand request, CancellationToken cancellationToken)
        {
            var announcement = new Models.Announcement
            {
                Title = request.newAnnouncement.Title,      
                Description = request.newAnnouncement.Description,
                ImageUrl = request.newAnnouncement.ImageUrl,
                IsPublished = request.newAnnouncement.IsPublished,
                IsDeleted = request.newAnnouncement.IsDeleted,
                CreatedByUserId = request.newAnnouncement.CreatedByUserId,
                CreatedDate = DateTime.Now
            };

            _context.Announcements.Add(announcement);
            await _context.SaveChangesAsync(cancellationToken);

            return announcement.AnnouncementId;
        }
    }
}
