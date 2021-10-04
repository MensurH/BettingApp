using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models.DtoModels
{
    public class UpdateQuoteDto
    {
        public int MatchId { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
    }
}
