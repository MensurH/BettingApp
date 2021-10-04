using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models.DtoModels
{
    public class BetReadDto
    {
        public int Id { get; set; }
        public int QuoteId { get; set; }
        public int Amount { get; set; }
        public bool Updated { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
