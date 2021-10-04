using BettingSite.Data;
using BettingSite.Interfaces;
using BettingSite.Models;
using BettingSite.Models.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Services
{
    public class BetService : IBetService
    {

        private readonly AppDbContext _context;

        public BetService(AppDbContext context) {
            _context = context;
        }
        public Bet AddBet(Bet bet)
        {
            bet.InsertedAt = DateTime.Now;
            _context.Bets.Add(bet);
            _context.SaveChanges();
            return bet;
        }

        public void DeleteBet(Bet bet)
        {
            if (bet == null)
            {
                throw new ArgumentNullException(nameof(bet));
            }
            _context.Bets.Remove(bet);
        }

        public List<Bet> GetAllBets()
        {
          return  _context.Bets.ToList();
        }

        public Bet GetBetById(int id)
        {
            return _context.Bets.FirstOrDefault(b => b.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateBet(Bet bet)
        {
            bet.UpdatedAt = DateTime.Now;
            bet.Updated = true;
            _context.Bets.Update(bet);      
            _context.SaveChanges();
        }
  
 
       
    }
}
