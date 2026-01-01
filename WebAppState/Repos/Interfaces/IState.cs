using WebAppState.Models;

namespace WebAppState.Repos.Interfaces
{
    public interface IState
    {
        public Task<IEnumerable<State>> GetStatesAsync();
        public Task<State?> GetStateByIdAsync(int id);
        public Task<State?> GetStateByNameAsync(string name);

        public Task<State> CreateStateAsync(State state);

        public Task<State> UpdateStateAsync(State state);



        public Task<bool> DeleteStateAsync(int id);
    }
}
