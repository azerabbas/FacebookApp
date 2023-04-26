namespace FaceBookApplication.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {

        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entity);
        bool Remove(T entity);
        bool RemoveRange(List<T> datas);
        Task<bool> Remove(string id);
        bool UpdateAsync(T entity);


    }
}
