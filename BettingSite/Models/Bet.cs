using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public int QuoteId { get; set; }
        public  Quote Quote { get; set; }
        public int Amount { get; set; }
        public bool Updated { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
