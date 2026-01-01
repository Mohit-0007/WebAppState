using WebAppState.Models;
namespace WebAppState.Repos.Interfaces
{
    public interface ICity
    {
        public Task<IEnumerable<City>> GetCitiesAsync();
        public Task<City?> GetCityByIdAsync(int id);
        public Task<City?> GetCityByNameAsync(string name);
        public Task<City> CreateCityAsync(City city);

        public Task<City> UpdateCityAsync(City city);

        public Task<bool> DeleteCityAsync(int id);
    }
}
