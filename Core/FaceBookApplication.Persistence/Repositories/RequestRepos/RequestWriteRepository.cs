using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.RequestRepos
{
    public class RequestWriteRepository : WriteRepository<Request>, IRequestWriteRepository
    {
        public RequestWriteRepository(FacebookContext context) : base(context)
        {
        }
    }
}
