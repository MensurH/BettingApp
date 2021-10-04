using BettingSite.Data;
using BettingSite.Interfaces;
using BettingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Services
{
    public class MatchService : IMatchService
    {
        private readonly AppDbContext _context;

        public MatchService(AppDbContext context)
        {
            _context = context;
        }

        public Match AddMatch(Match match)
        {
            match.InsertedAt = DateTime.Now;
            _context.Matches.Add(match);
            _context.SaveChanges();
            return match;
        }

        public void DeleteMatch(Match match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }
            _context.Matches.Remove(match);
        }

        public List<Match> GetAllMatches()
        {
            return _context.Matches.ToList();
        }

        public Match GetMatchById(int id)
        {
            return _context.Matches.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateMatch(Match match)
        {
            match.UpdatedAt = DateTime.Now;
            match.Updated = true;
            _context.Matches.Update(match);
            _context.SaveChanges();
        }
    }
}
