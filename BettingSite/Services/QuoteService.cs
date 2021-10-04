using BettingSite.Data;
using BettingSite.Interfaces;
using BettingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Services
{
    public class QuoteService : IQuoteService
    {

        private readonly AppDbContext _context;

        public QuoteService(AppDbContext context)
        {
            _context = context;
        }
        public Quote AddQuote(Quote quote)
        {
            quote.InsertedAt = DateTime.Now;
            _context.Quotes.Add(quote);
            _context.SaveChanges();
            return quote;
        }
       public void DeleteQuote(Quote quote)
        {
            if (quote == null)
            {
                throw new ArgumentNullException(nameof(quote));
            }
            _context.Quotes.Remove(quote);
        }

        public List<Quote> GetAllQuotes()
        {
            return _context.Quotes.ToList();
        }

        public Quote GetQuoteById(int id)
        {
            return _context.Quotes.FirstOrDefault(q => q.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateQuote(Quote quote)
        {
            quote.UpdatedAt = DateTime.Now;
            quote.Updated = true;
            _context.Quotes.Update(quote);
            _context.SaveChanges();
        }
    }
}
