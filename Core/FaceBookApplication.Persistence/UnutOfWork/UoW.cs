using FaceBookApplication.Application.Repositories;
using FaceBookApplication.Domain.Entity.Common;
using FaceBookApplication.Persistence.Context;
using FaceBookApplication.Persistence.Repositories;

namespace FaceBookApplication.Persistence.UnutOfWork
{
    public class UoW : IUoW
    {
        private readonly FacebookContext _context;

        public UoW(FacebookContext context)
        {
            _context=context;
        }

        public IReadRepository<T> GetReadRepository<T>() where T : BaseEntity
        {
            return new ReadRepository<T>(_context);
        }

        public IWriteRepository<T> GetWriteRepository<T>() where T : BaseEntity
        {
            return new WriteRepository<T>(_context);
        }

        public void Save() => _context.SaveChanges();
    }
}
