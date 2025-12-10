using CommunityApplication.DTO;
using CommunityApplication.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CommunityApplication.Features.Announcement.Query.GetAllAnnouncementsQuery
{
    public class GetAllAnnouncementsHandler : IRequestHandler<GetAllAnnouncementsQuery, List<AnnouncementDto>>
    {
        private readonly ApplicationDbContext _context;
        public GetAllAnnouncementsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AnnouncementDto>> Handle(GetAllAnnouncementsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Announcements
                .Where(a => !a.IsDeleted)
                .Select(a => new AnnouncementDto
                {
                    AnnouncementId = a.AnnouncementId,
                    Title = a.Title,
                    Description = a.Description,
                    ImageUrl = a.ImageUrl,
                    IsPublished = a.IsPublished ?? false,
                    CreatedByUserId = a.CreatedByUserId,
                    CreatedDate = a.CreatedDate ?? DateTime.Now
                })
                .ToListAsync(cancellationToken);
        }
    }
}
