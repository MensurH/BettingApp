using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models.DtoModels
{
    public class TeamReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stadium { get; set; }
        public bool Updated { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
