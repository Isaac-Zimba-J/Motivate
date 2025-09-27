using System;
using Motivate.Models;

namespace Motivate.Repositories.Contracts;

public interface IQuoteRepository
{
    // Define repository methods here
    Task AddQuoteAsync(Quote quote);
    Task<Quote> GetRandomQuoteAsync();
}
