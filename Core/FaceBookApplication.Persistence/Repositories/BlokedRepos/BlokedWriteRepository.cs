using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.BlokedRepos
{
    public class BlokedWriteRepository : WriteRepository<Bloked>, IBlokedWriteRepository
    {
        public BlokedWriteRepository(FacebookContext context) : base(context)
        {
        }
    }
}
