using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballDataWrapper.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballDataWrapper.Controllers
{
    [Route("api/import-league")]
    [ApiController]
    public class ImportLeagueController : ControllerBase
    {
        private LeagueService leagueService;

        public ImportLeagueController(LeagueService _leagueService )
        {
            leagueService = _leagueService;
        }            

        // GET api/values/5
        [HttpGet("{leagueCode}")]
        public ActionResult<string> Get(string leagueCode)
        {
            return Ok();
        }
    }
}