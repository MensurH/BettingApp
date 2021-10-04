using AutoMapper;
using BettingSite.Interfaces;
using BettingSite.Models;
using BettingSite.Models.DtoModels;
using BettingSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace BettingSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        private IBetService _betService;
        private IMapper _mapper;
        public BetController(IBetService betService, IMapper mapper)
        {
            _betService = betService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Bet>> GetAllBets()
        {
            var betItems = _betService.GetAllBets();
            return Ok(_mapper.Map<IEnumerable<BetReadDto>>(betItems));
        }
        [HttpGet("{id}")]
        public ActionResult <BetReadDto> GetBetById(int id)
        {
            var betItem = _betService.GetBetById(id);
            if(betItem !=null)
            {
                return Ok(_mapper.Map<BetReadDto>(betItem));
            }
            return NotFound();
        }



        [HttpPost]
        public IActionResult AddBet(BetDto betDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var bet = _mapper.Map<Bet>(betDto);
            _betService.AddBet(bet);
            var betReadDto = _mapper.Map<BetReadDto>(bet);
            return Ok(betReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBet(int id, UpdateBetDto updateBetDto)
        {
            var bet = _betService.GetBetById(id);
            if(bet ==null)
            {
                return NotFound();
            }

            _mapper.Map(updateBetDto, bet);

            _betService.UpdateBet(bet);

        

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBet(int id)
        {
            var deleteBet = _betService.GetBetById(id);
            if (deleteBet == null)
            {
                return NotFound();
            }
            _betService.DeleteBet(deleteBet);
            _betService.SaveChanges();

            return NoContent();
        }



    }
}
