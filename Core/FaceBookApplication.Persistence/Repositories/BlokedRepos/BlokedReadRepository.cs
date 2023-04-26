using FaceBookApplication.Application.Repositories.Entities;
using FaceBookApplication.Domain.Entity;
using FaceBookApplication.Persistence.Context;

namespace FaceBookApplication.Persistence.Repositories.BlokedRepos
{
    public class BlokedReadRepository : ReadRepository<Bloked>, IBlokedReadRepository
    {
        public BlokedReadRepository(FacebookContext context) : base(context)
        {
        }
    }
}
