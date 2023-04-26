using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.FriendRepos
{
    public class FriendReadRepository : ReadRepository<Friend>, IFriendReadRepository
    {
        public FriendReadRepository(FacebookContext context) : base(context)
        {
        }
    }
}
