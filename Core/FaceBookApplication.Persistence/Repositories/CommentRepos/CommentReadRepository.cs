using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.CommentRepos
{
    public class CommentReadRepository : ReadRepository<Comment>, ICommentReadRepository
    {
        public CommentReadRepository(FacebookContext context) : base(context)
        {
        }
    }
}
