using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BettingSite.Models;
using BettingSite.Models.DtoModels;

namespace BettingSite.Profiles
{
    public class QuoteProfile : Profile
    {
        public QuoteProfile()
        {
            CreateMap<QuoteDto, Quote>();
            CreateMap<Quote, QuoteReadDto>();
            CreateMap<UpdateQuoteDto, Quote>();
            CreateMap<Quote, UpdateQuoteDto>();


        }
    }
}
