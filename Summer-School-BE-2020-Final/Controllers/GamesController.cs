using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Summer_School_BE_2020_Final.Models;

namespace Summer_School_BE_2020_Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private ApplicationContext db;
        public GamesController(ApplicationContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<ActionResult<Game>> Post(Game game)
        {
            if (game == null)
            {
                return BadRequest();
            }

            db.Games.Add(game);
            await db.SaveChangesAsync();
            return Ok(game);

        }
        [HttpGet]
        public async Task<List<Game>> Get()
        {
            List<Game> Games =  db.Games.ToList();
            return Games;
        }

    }
}
