using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.FriendRepos
{
    public class FriendWriteRepository : WriteRepository<Friend>, IFriendWriteRepository
    {
        public FriendWriteRepository(FacebookContext context) : base(context)
        {
        }
    }
}
