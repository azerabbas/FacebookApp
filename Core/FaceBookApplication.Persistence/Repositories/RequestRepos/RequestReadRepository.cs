using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.RequestRepos
{
    public class RequestReadRepository : ReadRepository<Request>, IRequestReadRepository
    {
        public RequestReadRepository(FacebookContext context) : base(context)
        {
        }
    }
}
