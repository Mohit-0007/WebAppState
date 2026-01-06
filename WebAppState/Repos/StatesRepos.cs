using WebAppState.Repos.Interfaces;
using WebAppState.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppState.Repos
{
    public class StatesRepos<T> :IStates<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbset;
        public StatesRepos(AppDbContext context ) { 
        
            _context = context;
            _dbset = context.Set<T>();

        }
       public async Task<IEnumerable<T>> GetAllAsync()
       {
           return await _dbset.ToListAsync();
       }
     public  async Task<T?> GetByIdAsync(int id)
     {
           var result=await _dbset.FindAsync(id);
              return result;

        }
       public async Task<T?> GetByNameAsync(string name)
        {
            var result = await _dbset.FindAsync(name);
            return result;
        }
      public async Task<T> CreateAsync(T entity)
        {
           await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;

        }
      public async Task<T> UpdateAsync(T entity)
        {
            _dbset.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
       public Task<bool> DeleteAsync(int id)
        {
            _dbset.Remove(_dbset.Find(id)!);
            _context.SaveChangesAsync();
            return Task.FromResult(true);
        }
    }
}
