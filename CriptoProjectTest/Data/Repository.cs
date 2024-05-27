using CriptoProjectTest.Entityes;
using CriptoProjectTest.Interfases;
using Microsoft.EntityFrameworkCore;
using NewForReact.Data;
using static System.Net.Mime.MediaTypeNames;

namespace CriptoProjectTest.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected DataDbContent _repositoryContext;
        public Repository(DataDbContent repositoryContext) => _repositoryContext = repositoryContext;

        public async Task<List<T>> FindAllAsync() => await _repositoryContext.Set<T>().ToListAsync();

        public async Task<T> FindByIdAsync(int id)
        {
            return await _repositoryContext.Set<T>().FindAsync(id);

        }

        public async Task CreateAsync(T entity)
        {
            await _repositoryContext.Set<T>().AddAsync(entity);
            await _repositoryContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repositoryContext.Set<T>().Update(entity);
            await _repositoryContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            _repositoryContext.Set<T>().Remove(entity);
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
