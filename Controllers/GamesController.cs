using System.Collections.Generic;
using app.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        public static List<Games> GetGames()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games(){Id = 1, Name = "Games 1", Price = 10});
            games.Add(new Games(){Id = 2, Name = "Games 2", Price = 15});
            games.Add(new Games(){Id = 3, Name = "Games 3", Price = 20});
            games.Add(new Games(){Id = 4, Name = "Games 4", Price = 25});
            games.Add(new Games(){Id = 5, Name = "Games 5", Price = 30});
            return games;
        }

        [HttpGet]
        public IEnumerable<Games> GetGames_List()
        {
            return GetGames();
        }

        [HttpGet("{id}")]
        public ActionResult<Games> GetGamesByID(int id) {
            var games = GetGames().Find(x => x.Id == id);
            return games != null ? games : NotFound();
        }
    }
}   