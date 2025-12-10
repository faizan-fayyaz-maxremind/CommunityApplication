using CommunityApplication.Models;

namespace CommunityApplication.Repositories.IRepositories
{
    public interface IAnnouncementRepository
    {
        Task<IEnumerable<Announcement>> GetAllAnnouncementAsync();
        Task<Announcement> GetByIdAnnouncementAsync(long id);
        Task AddAnnouncementAsync(Announcement announcement);
        Task UpdateAnnouncementAsync(Announcement announcement);
        Task DeleteAnnouncementAsync(long id);
    }
}
