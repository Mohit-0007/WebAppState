//using WebAppState.Models;
//using WebAppState.Repos.Interfaces;
//using Microsoft.EntityFrameworkCore;


//namespace WebAppState.Repos
//{
//    public class DistrictRepo : IDistrict
//    {
//        private readonly AppDbContext _context;
//        public DistrictRepo(AppDbContext context)
//        {
//            _context= context;
//        }
//        public async Task<IEnumerable<District>> GetDistrictsAsync()
//        {
//            return await _context.Districts.ToListAsync();
//        }
//        public async Task<District?> GetDistrictByIdAsync(int id)
//        {
//            var district = await _context.Districts.FindAsync(id);
//            if (district == null)
//            {
//                return null;
//            }
//            return district;

//        }
//        public async Task<District?> GetDistrictByNameAsync(string name)
//        {
//            var district = await _context.Districts.FindAsync(name);
//            if (district == null)
//            {
//                return null;
//            }
//            return district;
//        }
//        public async Task<District> CreateDistrictAsync(District district)
//        {
//            _context.Districts.Add(district);
//            await _context.SaveChangesAsync();
//            return district;
//        }
//        public async Task<District> UpdateDistrictAsync(District district)
//        {
          
//            _context.Districts.Update(district);
//            await _context.SaveChangesAsync();
//            return district;

//        }
//        public Task<bool> DeleteDistrictAsync(int id)
//        {
//            var reult = _context.Districts.Find(id);
//            if (reult == null)
//            {
//                return Task.FromResult(false);
//            }
//            _context.Districts.Remove(reult);
//            _context.SaveChangesAsync();
//            return Task.FromResult(true);
//        }
//    }
//}
