using CriptoProjectTest.Entityes;

namespace CriptoProjectTest.Interfases
{
    public interface IRepository<T>
    {
        Task<List<T>> FindAllAsync();

        Task<T> FindByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
