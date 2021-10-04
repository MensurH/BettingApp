using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BettingSite.Models;
using BettingSite.Models.DtoModels;

namespace BettingSite.Profiles
{
    public class MatchProfile : Profile 
    {
        public MatchProfile()
        {
            CreateMap<MatchDto, Match>();
            CreateMap<Match, MatchReadDto>();
            CreateMap<UpdateMatchDto, Match>();
            CreateMap<Match, UpdateMatchDto>();


        }
    }
}
