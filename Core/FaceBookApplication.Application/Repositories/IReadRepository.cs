using System.Linq.Expressions;

namespace FaceBookApplication.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {

        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetFindAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(int id);

    }

}
