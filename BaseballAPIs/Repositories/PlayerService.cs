using BaseballAPIs.Data;
using BaseballAPIs.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;



namespace BaseballAPIs.Repositories
{
    public class PlayerService : IPlayerService
    {
        private readonly DBContextClass _dbContextClass;
        public PlayerService(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Player>> PlayerGetDetails(int PID)
        {

            var param = new SqlParameter("@PID", PID);
            var playerDetails = await Task.Run(() => _dbContextClass.Player.FromSqlRaw("exec spGetPlayerDetails @PID", param).ToListAsync());
            return playerDetails;

        }

        public async Task<int> AddPlayer(Player player)
        {

            var PID = new SqlParameter("@PID", player.PID);
            var pName = new SqlParameter("Name", player.Name);
            var pNumber = new SqlParameter("Number", player.Number);
            var pPosition = new SqlParameter("Position", player.Position);
            var TID = new SqlParameter("TID", player.TID);
            var playerDetails = await Task.Run(() => _dbContextClass.Database.ExecuteSqlRaw("exec spAddPlayer @PID SMALLINT,\r\n    @Name NVARCHAR(max),\r\n    @Number NVARCHAR(max),\r\n    @Position NVARCHAR(max), \r\n    @TID SMALLINT"));
            return playerDetails;

        }

    }
}  
