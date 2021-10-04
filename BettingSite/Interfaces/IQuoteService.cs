using BettingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Interfaces
{
    public interface IQuoteService
    {
        bool SaveChanges();
        public Quote AddQuote(Quote quote);
        public void UpdateQuote(Quote quote);
        public List<Quote> GetAllQuotes();

        public Quote GetQuoteById(int id);
        public void DeleteQuote(Quote quote);
    }
}
