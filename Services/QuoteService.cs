using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Motivate.Models;
using Motivate.Repositories.Contracts;
using Motivate.Services.Contracts;

namespace Motivate.Services;

public class QuoteService : IQuoteService
{

    private readonly HttpClient httpClient;
    private readonly IQuoteRepository quoteRepository;

    private const string url = "https://zenquotes.io/api/random";



    public QuoteService(IQuoteRepository _quoteRepository)
    {
        httpClient = new HttpClient();
        quoteRepository = _quoteRepository;
    }
    public async Task<Quote> GetQuoteAsync()
    {
        if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
        {

            try
            {
                var response = await httpClient.GetStringAsync(url);

                // Deserialize as an array since ZenQuotes returns [ { "q": "...", "a": "..." } ]
                var quotes = JsonSerializer.Deserialize<Quote[]>(response);

                if (quotes != null && quotes.Length > 0)
                {
                    return quotes[0];
                }
                else
                {
                    throw new Exception("No quote found in the response.");
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch quote.");
            }
            throw new Exception("No internet connection.");
        }
        else
        {
            // get from local db
            var quote = await quoteRepository.GetRandomQuoteAsync();
        }
        return null;
    }
}
