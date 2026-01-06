//using Microsoft.EntityFrameworkCore;
//using WebAppState.Models;
//using WebAppState.Repos.Interfaces;

//namespace WebAppState.Repos
//{
//    public class StateRepo : IState
//    {
//        private readonly AppDbContext _context;
//        public StateRepo(AppDbContext context)
//        {
//            _context= context;
//        }
//        public async Task<IEnumerable<State>> GetStatesAsync()
//        {
//             return await _context.States.ToListAsync();
//        }

//        public async Task<State?> GetStateByIdAsync(int id)
//        {
//            var result =await _context.States.FirstOrDefaultAsync(s => s.Id == id);

//            if (result==null)
//            {
//                return null;
//            }

//             return result;
          
//        }

//        public async Task<State?> GetStateByNameAsync(string name)
//        {
//            var result = await _context.States.FirstOrDefaultAsync(s => s.Name == name);

//            if (result == null)
//            {
//                return null;
//            }

//            return result;

//        }

//        public async Task<State> CreateStateAsync(State state)
//        {
//               _context.States.Add(state);  
//            await  _context.SaveChangesAsync();
//            return state;

//        }

//        public async Task<State> UpdateStateAsync(State state)
//        {
//                _context.States.Update(state);
//                await _context.SaveChangesAsync();
//            return state;
//        }
//        public async Task<bool> DeleteStateAsync(int id)
//        {
//            var state = await _context.States.FirstOrDefaultAsync(s => s.Id == id);

//            if (state==null)
//            {
//                return false;
//            }
//            _context.States.Remove(state);
//            await _context.SaveChangesAsync();
//            return true;

//        }
//    }
//}
