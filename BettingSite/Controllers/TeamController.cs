using AutoMapper;
using BettingSite.Interfaces;
using BettingSite.Models;
using BettingSite.Models.DtoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private ITeamService _teamService;
        private IMapper _mapper;

        public TeamController(ITeamService teamService, IMapper mapper)
        {
            _mapper = mapper;
            _teamService = teamService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Team>> GetAllTeams()
        {
            var teamItems = _teamService.GetAllTeams();
            return Ok(_mapper.Map<IEnumerable<TeamReadDto>>(teamItems));
        }
        [HttpGet("{id}")]
        public ActionResult<TeamReadDto> GetTeamById(int id)
        {
            var teamItem = _teamService.GetTeamById(id);
            if (teamItem != null)
            {
                return Ok(_mapper.Map<TeamReadDto>(teamItem));
            }
            return NotFound();
        }



        [HttpPost]
        public IActionResult AddTeam(TeamDto teamDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var team = _mapper.Map<Team>(teamDto);
            _teamService.AddTeam(team);
            var teamReadDto = _mapper.Map<TeamReadDto>(team);
            return Ok(teamReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTeam(int id, UpdateTeamDto updateTeamDto)
        {
            var team = _teamService.GetTeamById(id);
            if (team == null)
            {
                return NotFound();
            }

            _mapper.Map(updateTeamDto, team);

            _teamService.UpdateTeam(team);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTeam(int id)
        {
            var team = _teamService.GetTeamById(id);
            if (team == null)
            {
                return NotFound();
            }
            _teamService.DeleteTeam(team);
            _teamService.SaveChanges();

            return NoContent();
        }

    }
}
