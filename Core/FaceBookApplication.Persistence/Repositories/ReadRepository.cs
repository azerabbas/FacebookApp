using FaceBookApplication.Application.Repositories;
using FaceBookApplication.Domain.Entity.Common;
using FaceBookApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FaceBookApplication.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly FacebookContext _context;

        public ReadRepository(FacebookContext context)
        {
            _context=context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll() => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);
        public async Task<T> GetFindAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        public async Task<T> GetByIdAsync(int id) => await Table.FindAsync(id);

      


    }
}
