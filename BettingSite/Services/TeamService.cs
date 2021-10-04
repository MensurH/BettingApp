using BettingSite.Data;
using BettingSite.Interfaces;
using BettingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Services
{
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _context;

        public TeamService(AppDbContext context)
        {
            _context = context;
        }

        public Team AddTeam(Team team)
        {
            team.InsertedAt = DateTime.Now;
            _context.Teams.Add(team);
            _context.SaveChanges();
            return team;
        }

        

        public void DeleteTeam(Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException(nameof(team));
            }
            _context.Teams.Remove(team);
        }

        public List<Team> GetAllTeams()
        {
            return _context.Teams.ToList();
        }

        public Team GetTeamById(int id)
        {
            return _context.Teams.FirstOrDefault(t => t.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateTeam(Team team)
        {
            team.UpdatedAt = DateTime.Now;
            team.Updated = true;
            _context.Teams.Update(team);
            _context.SaveChanges();
        }
    }
}
