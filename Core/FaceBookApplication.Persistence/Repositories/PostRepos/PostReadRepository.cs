using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.PostRepos
{
    public class PostReadRepository : ReadRepository<Post>, IPostReadRpository
    {
        public PostReadRepository(FacebookContext context) : base(context)
        {
        }
    }
}
