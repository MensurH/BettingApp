using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models.DtoModels
{
    public class MatchReadDto
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public DateTime MatchTime { get; set; }
        public DateTime InsertedAt { get; set; }
        public bool Updated { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Quote> Quotes { get; set; }
    }
}
