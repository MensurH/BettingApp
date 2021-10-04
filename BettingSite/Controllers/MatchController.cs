using AutoMapper;
using BettingSite.Interfaces;
using BettingSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BettingSite.Models.DtoModels;

namespace BettingSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private IMatchService _matchService;
        private IMapper _mapper;
       
        public MatchController(IMatchService matchService, IMapper mapper)
        {
            _mapper = mapper;
            _matchService = matchService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Match>> GetAllMatches()
        {
            var matchItems = _matchService.GetAllMatches();
            return Ok(_mapper.Map<IEnumerable<MatchReadDto>>(matchItems));
        }
        [HttpGet("{id}")]
        public ActionResult<BetReadDto> GetMatchById(int id)
        {
            var matchItem = _matchService.GetMatchById(id);
            if (matchItem != null)
            {
                return Ok(_mapper.Map<MatchReadDto>(matchItem));
            }
            return NotFound();
        }



        [HttpPost]
        public IActionResult AddMatch(MatchDto matchDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var match = _mapper.Map<Match>(matchDto);
            _matchService.AddMatch(match);
            var matchReadDto = _mapper.Map<MatchReadDto>(match);
            return Ok(matchReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateMatch(int id, UpdateMatchDto updateMatchDto)
        {
            var match = _matchService.GetMatchById(id);
            if (match == null)
            {
                return NotFound();
            }

            _mapper.Map(updateMatchDto, match);

            _matchService.UpdateMatch(match);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMatch(int id)
        {
            var match = _matchService.GetMatchById(id);
            if (match == null)
            {
                return NotFound();
            }
            _matchService.DeleteMatch(match);
            _matchService.SaveChanges();

            return NoContent();
        }
    }
}
