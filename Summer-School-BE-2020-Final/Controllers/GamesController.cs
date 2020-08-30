using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Summer_School_BE_2020_Final.Interfaces;
using Summer_School_BE_2020_Final.Models;

namespace Summer_School_BE_2020_Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _service;
        private readonly IValidateService _validateService;

        public GamesController(IGameService service, IValidateService validateService)
        {
            _service = service;
            _validateService = validateService;

        }
        [Authorize(Roles = "seller")]
        [HttpPost("AddGame")]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            if (game == null)
            {
                return BadRequest();
            }

            try
            {
                _service.AddGame(game);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Получить список игр.
        /// </summary>
        /// <response code = "200" > Успешное выполнение.</response>
        /// <response code = "204" > Контент не найден</response>
        /// <response code = "401" > Данный запрос требует аутентификации.</response>
        /// <response code = "500" > Непредвиденная ошибка сервера.</response>
        [Authorize]
        [HttpGet("ViewGames")]
        public async Task<Game[]> ViewGames()
        {
            return await _service.ViewGames();
        }

        [Authorize(Roles = "buyer")]
        [HttpPost("BuyGame")]
        public async Task<ActionResult<Purchase>> BuyGame(Purchase purchase)
        {
            if (purchase == null)
            {
                return BadRequest();
            }

            try
            {
                _service.BuyGame(purchase);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}
