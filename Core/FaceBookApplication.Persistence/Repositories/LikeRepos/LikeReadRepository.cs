using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.LikeRepos
{
    public class LikeReadRepository : ReadRepository<Like>, ILikeReadRepository
    {
        public LikeReadRepository(FacebookContext context) : base(context)
        {
        }
    }
}
