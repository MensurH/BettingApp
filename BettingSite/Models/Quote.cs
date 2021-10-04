using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public virtual Match Match { get; set; }
        public string Type { get; set; }
        public bool Updated { get; set; }
        public double Value { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<Bet> Bets { get; set; }
    }
}
