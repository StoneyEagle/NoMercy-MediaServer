using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieWatchProviders
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("results")] public Countries<PaymentType> Results { get; set; } = new();
}

public class PaymentType
{
    [JsonProperty("link")] public Uri Link { get; set; } = null!;

    [JsonProperty("flatrate")] public PaymentDetails[] FlatRate { get; set; } = Array.Empty<PaymentDetails>();

    [JsonProperty("rent")] public PaymentDetails[] Rent { get; set; } = Array.Empty<PaymentDetails>();

    [JsonProperty("buy")] public PaymentDetails[] Buy { get; set; } = Array.Empty<PaymentDetails>();
}

public class PaymentDetails
{
    [JsonProperty("display_priority")] public int DisplayPriority { get; set; }

    [JsonProperty("logo_path")] public string LogoPath { get; set; } = string.Empty;

    [JsonProperty("provider_id")] public int ProviderId { get; set; }

    [JsonProperty("provider_name")] public string ProviderName { get; set; } = string.Empty;
}