using BettingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Interfaces
{
     public interface ITeamService
    {
        bool SaveChanges();
        public Team AddTeam(Team team);
        public void UpdateTeam(Team team);
        public List<Team> GetAllTeams();

        public Team GetTeamById(int id);
        public void DeleteTeam(Team team);
    }
}
