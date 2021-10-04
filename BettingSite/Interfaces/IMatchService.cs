using BettingSite.Models;
using System;
using System.Collections.Generic;
using BettingSite.Models.DtoModels;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Interfaces
{
    public interface IMatchService
    {
        bool SaveChanges();
        public Match AddMatch(Match match);
        public void UpdateMatch(Match match);
        public List<Match> GetAllMatches();

        public Match GetMatchById(int id);
        public void DeleteMatch(Match match);
    }
}
