using System;
using Motivate.Models;

namespace Motivate.Services.Contracts;

public interface IQuoteService
{
    /// <summary>
    /// Gets a random motivational quote.
    /// </summary>
    /// 
    Task<Quote> GetQuoteAsync();
}
