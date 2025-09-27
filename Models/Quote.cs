using System;
using System.Text.Json.Serialization;
using SQLite;

namespace Motivate.Models;

public class Quote
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [JsonPropertyName("q")]
    public string QuoteText { get; set; } = string.Empty;

    [JsonPropertyName("a")]
    public string Author { get; set; } = string.Empty;
}
