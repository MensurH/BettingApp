using AutoMapper;
using BettingSite.Models;
using BettingSite.Models.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Profiles
{
    public class BetProfile : Profile
    {
        public BetProfile()
        {

            CreateMap<BetDto, Bet>();
            CreateMap<Bet, BetReadDto>();
            CreateMap<UpdateBetDto, Bet>();
            CreateMap<Bet, UpdateBetDto>();
        }



    }
}
