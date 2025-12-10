using CommunityApplication.DTO;
using MediatR;

namespace CommunityApplication.Features.Announcement.Command.UpdateAnnouncementCommand
{
    public class UpdateAnnouncementCommand : IRequest<AnnouncementDto>
    {
        public UpdateAnnouncementDto updateAnnouncementDto { get; set; }
        public UpdateAnnouncementCommand(UpdateAnnouncementDto updateAnnouncementDto)
        {
            this.updateAnnouncementDto = updateAnnouncementDto;
        }
    }
}
