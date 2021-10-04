using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Stadium { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Updated { get; set; }

        [InverseProperty("HomeTeam")]
        public virtual ICollection<Match> HomeMatches { get; set; }

        [InverseProperty("AwayTeam")]
        public virtual ICollection<Match> AwayMatches { get; set; }
    }
}
