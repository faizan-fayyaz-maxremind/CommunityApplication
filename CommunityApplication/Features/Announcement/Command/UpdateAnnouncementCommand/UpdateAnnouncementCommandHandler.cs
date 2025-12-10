using CommunityApplication.DTO;
using CommunityApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApplication.Features.Announcement.Command.UpdateAnnouncementCommand
{
    public class UpdateAnnouncementCommandHandler
    {
        private readonly ApplicationDbContext _context;

        public UpdateAnnouncementCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AnnouncementDto> Handle(UpdateAnnouncementCommand request, CancellationToken cancellationToken)
        {
            var existingAnnouncement = await _context.Announcements
                .FirstOrDefaultAsync(a => a.AnnouncementId == request.updateAnnouncementDto.AnnouncementId && !a.IsDeleted, cancellationToken);

            if (existingAnnouncement == null)
                throw new KeyNotFoundException("Announcement not found");


            existingAnnouncement.Title = request.updateAnnouncementDto.Title;
            existingAnnouncement.Description = request.updateAnnouncementDto.Description;
            //announcement.CategoryId = request.updateAnnouncementDto.CategoryId;
            existingAnnouncement.ImageUrl = request.updateAnnouncementDto.ImageUrl;
            existingAnnouncement.IsPublished = request.updateAnnouncementDto.IsPublished;
            existingAnnouncement.ModifiedDate = DateTime.Now;

            _context.Announcements.Add(existingAnnouncement);
            await _context.SaveChangesAsync(cancellationToken);

            var dto = new AnnouncementDto
            {
                AnnouncementId = existingAnnouncement.AnnouncementId,
                Title = existingAnnouncement.Title,
                Description = existingAnnouncement.Description,
                CategoryName = existingAnnouncement.Category?.CategoryName,
                ImageUrl = existingAnnouncement.ImageUrl,
                IsPublished = existingAnnouncement.IsPublished ?? false,
                CreatedByUserId = existingAnnouncement.CreatedByUserId,
                ModifiedDate = existingAnnouncement.ModifiedDate
            };

            return dto;
        }
    }
}
