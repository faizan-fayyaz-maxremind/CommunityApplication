using CommunityApplication.Models;
using CommunityApplication.Repositories.IRepositories;

namespace CommunityApplication.Repositories.Repositories
{
    public class AnnouncementRepository : IAnnouncementRepository
    {
        public Task AddAnnouncementAsync(Announcement announcement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAnnouncementAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Announcement>> GetAllAnnouncementAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Announcement> GetByIdAnnouncementAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAnnouncementAsync(Announcement announcement)
        {
            throw new NotImplementedException();
        }
    }
}
