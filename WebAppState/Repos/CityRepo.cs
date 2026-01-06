//using Microsoft.EntityFrameworkCore;
//using WebAppState.Models;
//using WebAppState.Repos.Interfaces;

//namespace WebAppState.Repos
//{
//    public class CityRepo : ICity
//    {
//        private readonly AppDbContext _context;
//        public CityRepo(AppDbContext context)
//        {
//            _context = context;
//        }
//        public async Task<IEnumerable<City>> GetCitiesAsync()
//        {
//            return await _context.Cities.ToListAsync();
//        }
//        public async Task<City?> GetCityByIdAsync(int id)
//        {
//            var cities = await _context.Cities.FindAsync(id);
//            if (cities == null)
//            {
//                return null;
//            }
//            return cities;

//        }
//        public async Task<City?> GetCityByNameAsync(string name)
//        {
//           var  cities = await _context.Cities.FindAsync(name);
//            if (cities == null)
//            {
//                return null;
//            }
//            return cities;
//        }
//        public async Task<City> CreateCityAsync(City city)
//        {
//            _context.Cities.Add(city);
//            await _context.SaveChangesAsync();
//            return city;


//        }

//        public async Task<City> UpdateCityAsync(City city)
//        {
//            _context.Cities.Update(city);
//            await _context.SaveChangesAsync();
//            return city;

//        }

//        public Task<bool> DeleteCityAsync(int id)
//        {

//            var result = _context.Cities.Find(id);
//            if (result == null)
//            {
//                return Task.FromResult(false);
//            }
//            _context.Cities.Remove(result);
//            _context.SaveChangesAsync();
//            return Task.FromResult(true);
//        }
//    }
//}
