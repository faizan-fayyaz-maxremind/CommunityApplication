using CommunityApplication.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CommunityApplication.Features.Announcement.DeleteAnnouncementCommand
{
    public class DeleteAnnouncementCommandHandler : IRequestHandler<DeleteAnnouncementCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public DeleteAnnouncementCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteAnnouncementCommand request, CancellationToken cancellationToken)
        {
            var announcement = await _context.Announcements
                .FirstOrDefaultAsync(a => a.AnnouncementId == request.announcementId && !a.IsDeleted, cancellationToken);

            if (announcement == null)
                throw new KeyNotFoundException("Announcement not found");

            announcement.IsDeleted = true;
            announcement.ModifiedDate = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
