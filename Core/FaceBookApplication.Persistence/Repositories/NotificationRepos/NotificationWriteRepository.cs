using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.NotificationRepos
{
    public class NotificationWriteRepository : WriteRepository<Notification>, INotificationWriteRepository
    {
        public NotificationWriteRepository(FacebookContext context) : base(context)
        {
        }
    }
}
