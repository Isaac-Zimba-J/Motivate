using System;
using Motivate.Models;
using Motivate.Repositories.Contracts;
using SQLite;

namespace Motivate.Repositories;

public class QuoteRepository : IQuoteRepository
{
    private readonly SQLiteAsyncConnection dbPath;

    public QuoteRepository(SQLiteAsyncConnection _dbPath)
    {
        dbPath = _dbPath;
        dbPath.CreateTableAsync<Quote>().Wait();
    }


    public async Task AddQuoteAsync(Quote quote)
    {
        if (quote != null)
            await dbPath.InsertAsync(quote);
    }

    public async Task<Quote> GetRandomQuoteAsync()
    {
        var all = await GetAllQuotesAsync();
        if (all == null || all.Count == 0) return null;
        var rnd = new Random();
        return all[rnd.Next(all.Count)];
    }

    public Task<List<Quote>> GetAllQuotesAsync()
    {
        return dbPath.Table<Quote>().ToListAsync();
    }
}
