using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models.DtoModels
{
    public class UpdateMatchDto
    {
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public DateTime MatchTime { get; set; }
    }
}
