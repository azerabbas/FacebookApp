using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.LikeRepos
{
    public class LikeWriteRepository : WriteRepository<Like>, ILikeWriteRepository
    {
        public LikeWriteRepository(FacebookContext context) : base(context)
        {
        }
    }
}
