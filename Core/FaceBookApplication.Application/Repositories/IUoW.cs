using FaceBookApplication.Domain.Entity.Common;

namespace FaceBookApplication.Application.Repositories
{
    public interface IUoW
    {
        IReadRepository<T> GetReadRepository<T>() where T : BaseEntity;
        IWriteRepository<T> GetWriteRepository<T>() where T : BaseEntity;
        void Save();
    }
}
