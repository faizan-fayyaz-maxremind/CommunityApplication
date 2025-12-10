using CommunityApplication.DTO;
using MediatR;

namespace CommunityApplication.Features.Announcement.Command.CreateAnnouncementCommand
{
    public class CreateAnnouncementCommand : IRequest<long>
    {
        public CreateAnnouncementDto newAnnouncement { get; set; }
        public CreateAnnouncementCommand(CreateAnnouncementDto newAnnouncement)
        {
            this.newAnnouncement = newAnnouncement;
        }
    }
}
