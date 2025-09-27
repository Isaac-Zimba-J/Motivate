using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Motivate.Models;
using Motivate.Services.Contracts;

namespace Motivate.ViewModels;

public partial class MainPageViewModel : ObservableObject
{

    private readonly IQuoteService quoteService;


    [ObservableProperty]
    private string quoteContent = "Loading...";

    [ObservableProperty]
    private string quoteAuthor = string.Empty;
    [ObservableProperty]

    private bool isBusy;

    public MainPageViewModel(IQuoteService _quoteService)
    {
        quoteService = _quoteService;

    }


    [RelayCommand]
    private async Task LoadQuote()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var quote = await quoteService.GetQuoteAsync();
            QuoteContent = $"\"{quote.QuoteText}\"";
            QuoteAuthor = $"- {quote.Author}";
        }
        catch (Exception ex)
        {
            QuoteContent = "Failed to load quote.";
            QuoteAuthor = string.Empty;
        }
        finally
        {
            IsBusy = false;
        }
    }


}
