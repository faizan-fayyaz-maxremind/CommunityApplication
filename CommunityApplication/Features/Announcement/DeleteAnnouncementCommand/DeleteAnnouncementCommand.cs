using MediatR;

namespace CommunityApplication.Features.Announcement.DeleteAnnouncementCommand
{
    public class DeleteAnnouncementCommand : IRequest<Unit>
    {
        public long announcementId { get; set; }

        public DeleteAnnouncementCommand(long announcementId)
        {
            this.announcementId = announcementId;
        }
    }
}
