using CommunityApplication.DTO;
using MediatR;

namespace CommunityApplication.Features.Announcement.Query.GetAllAnnouncementsQuery
{
    public class GetAllAnnouncementsQuery : IRequest<List<AnnouncementDto>>
    {
        public GetAllAnnouncementsQuery()
        {}
    }
}
