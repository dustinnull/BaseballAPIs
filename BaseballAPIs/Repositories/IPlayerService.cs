using BaseballAPIs.Entities;

namespace BaseballAPIs.Repositories
{
    public interface IPlayerService
    {
        public Task<List<Player>> PlayerGetDetails(int PID);

        public Task<int> AddPlayer(Player player);

    }
}
