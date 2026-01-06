namespace WebAppState.Repos.Interfaces
{
    public interface IStates<T>where T : class
    {
      public Task<IEnumerable<T>> GetAllAsync();
      public  Task<T?> GetByIdAsync(int id);
       public Task<T?> GetByNameAsync(string name);
       public Task<T> CreateAsync(T entity);
      public Task<T> UpdateAsync(T entity);
       public  Task<bool> DeleteAsync(int id);
    }
}
