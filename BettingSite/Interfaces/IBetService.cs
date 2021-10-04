using BettingSite.Models;
using BettingSite.Models.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Interfaces
{
    public interface IBetService
    {
        bool SaveChanges();

        public Bet AddBet(Bet bet);
        public void UpdateBet(Bet bet);
        public List<Bet> GetAllBets();

        public Bet GetBetById(int id);
        public void DeleteBet(Bet bet);

    }
}
