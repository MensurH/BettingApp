using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models.DtoModels
{
    public class QuoteReadDto
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        public bool Updated { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
