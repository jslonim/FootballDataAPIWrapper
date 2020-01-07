using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FootballDataWrapper.Business;
using FootballDataWrapper.Business.Exceptions;
using FootballDataWrapper.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballDataWrapper.Controllers
{
    [Route("api/import-league")]
    [ApiController]
    public class ImportLeagueController : ControllerBase
    {
        private ILeagueService leagueService;

        public ImportLeagueController(ILeagueService _leagueService)
        {
            leagueService = _leagueService;

        }


        [HttpGet("{leagueCode}")]
        public ActionResult<string> Get(string leagueCode)
        {
            try
            {
                leagueService.ImportLeague(leagueCode);
            }
            catch (LeagueNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (LeagueImportedException e)
            {
                return Conflict(e.Message);
            }

            return Created(string.Empty, "Successfully imported");
        }
    }
}