using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballDataWrapper.Business.DTO;
using FootballDataWrapper.Business.Exceptions;
using FootballDataWrapper.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballDataWrapper.Controllers
{
    [Route("api/total-players")]
    [ApiController]
    public class TotalPlayersController : ControllerBase
    {
        private IPlayersService playerService;
        public TotalPlayersController(IPlayersService _playerService)
        {
            playerService = _playerService;
        }

        [HttpGet("{leagueCode}")]
        public ActionResult<string> Get(string leagueCode) 
        {
            try
            {
                TotalPlayersDTO result = new TotalPlayersDTO();
                result.Total = playerService.GetTotalPlayers(leagueCode);
                return Ok(result);
            }
            catch (LeagueNotFoundException)
            {

                return NotFound("Not found");
            }

        }
    }
}