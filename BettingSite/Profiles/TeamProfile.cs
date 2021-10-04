using AutoMapper;
using BettingSite.Models;
using BettingSite.Models.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Profiles

{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<TeamDto, Team>();
            CreateMap<Team, TeamReadDto>();
            CreateMap<UpdateTeamDto, Team>();
            CreateMap<Team, UpdateTeamDto>();
        }
    }
}
