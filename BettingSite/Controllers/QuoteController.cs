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
    public class QuoteController : ControllerBase
    {
        private IQuoteService _quoteService;
        private IMapper _mapper;

        public QuoteController(IQuoteService quoteService, IMapper mapper)
        {
            _mapper = mapper;
            _quoteService = quoteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Quote>> GetAllQuotes()
        {
            var quoteItems = _quoteService.GetAllQuotes();
            return Ok(_mapper.Map<IEnumerable<QuoteReadDto>>(quoteItems));
        }
        [HttpGet("{id}")]
        public ActionResult<QuoteReadDto> GetQuoteById(int id)
        {
            var quoteItem = _quoteService.GetQuoteById(id);
            if (quoteItem != null)
            {
                return Ok(_mapper.Map<QuoteReadDto>(quoteItem));
            }
            return NotFound();
        }



        [HttpPost]
        public IActionResult AddQuote(QuoteDto quoteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var quote = _mapper.Map<Quote>(quoteDto);
            _quoteService.AddQuote(quote);
            var quoteReadDto = _mapper.Map<QuoteReadDto>(quote);
            return Ok(quoteReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateQuote(int id, UpdateQuoteDto updateQuoteDto)
        {
            var quote = _quoteService.GetQuoteById(id);
            if (quote == null)
            {
                return NotFound();
            }

            _mapper.Map(updateQuoteDto, quote);

            _quoteService.UpdateQuote(quote);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteQuote(int id)
        {
            var quote = _quoteService.GetQuoteById(id);
            if (quote == null)
            {
                return NotFound();
            }
            _quoteService.DeleteQuote(quote);
            _quoteService.SaveChanges();

            return NoContent();
        }

    }
}
