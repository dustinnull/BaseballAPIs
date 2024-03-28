using BaseballAPIs.Entities;
using BaseballAPIs.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace BaseballAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : Controller
    {
        private readonly IPlayerService playerService;

        public PlayersController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        [HttpGet("{PID}")]
        public async Task<List<Player>> PlayerGetDetails(int PID)
        {

            var playerDetails = await playerService.PlayerGetDetails(PID);
            if (playerDetails == null)
            {
                //return NotFound();
            }
            return playerDetails;

        }

        [HttpPost]
        public async Task<ActionResult<int>> AddPlayer(Player player)
        {

            var playerDetails = await playerService.AddPlayer(player);
            return playerDetails;

        }
    }
}
