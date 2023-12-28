using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.TV;

public class WatchProviders
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("results")] public Results Results { get; set; }
}

public class Results
{
    [JsonProperty("AR")] public Type Ar { get; set; }

    [JsonProperty("AT")] public Type At { get; set; }

    [JsonProperty("AU")] public Type Au { get; set; }

    [JsonProperty("BE")] public Type Be { get; set; }

    [JsonProperty("BR")] public Type Br { get; set; }

    [JsonProperty("CA")] public Type Ca { get; set; }

    [JsonProperty("CH")] public Type Ch { get; set; }

    [JsonProperty("CL")] public Type Cl { get; set; }

    [JsonProperty("CO")] public Type Co { get; set; }

    [JsonProperty("CZ")] public Type Cz { get; set; }

    [JsonProperty("DE")] public Type De { get; set; }

    [JsonProperty("DK")] public Type Dk { get; set; }

    [JsonProperty("EC")] public Type Ec { get; set; }

    [JsonProperty("ES")] public Type Es { get; set; }

    [JsonProperty("FI")] public Type Fi { get; set; }

    [JsonProperty("FR")] public Type Fr { get; set; }

    [JsonProperty("GB")] public Type Gb { get; set; }

    [JsonProperty("HU")] public Type Hu { get; set; }

    [JsonProperty("IE")] public Type Ie { get; set; }

    [JsonProperty("IN")] public Type In { get; set; }

    [JsonProperty("IT")] public Type It { get; set; }

    [JsonProperty("JP")] public Type Jp { get; set; }

    [JsonProperty("MX")] public Type Mx { get; set; }

    [JsonProperty("NL")] public Type Nl { get; set; }

    [JsonProperty("NO")] public Type No { get; set; }

    [JsonProperty("NZ")] public Type Nz { get; set; }

    [JsonProperty("PE")] public Type Pe { get; set; }

    [JsonProperty("PL")] public Type Pl { get; set; }

    [JsonProperty("PT")] public Type Pt { get; set; }

    [JsonProperty("RO")] public Type Ro { get; set; }

    [JsonProperty("RU")] public Type Ru { get; set; }

    [JsonProperty("SE")] public Type Se { get; set; }

    [JsonProperty("TR")] public Type Tr { get; set; }

    [JsonProperty("US")] public Type Us { get; set; }

    [JsonProperty("VE")] public Type Ve { get; set; }

    [JsonProperty("ZA")] public Type Za { get; set; }
}

public class Type
{
    [JsonProperty("link")] public Uri Link { get; set; }

    [JsonProperty("buy")] public Data[] Buy { get; set; }

    [JsonProperty("flatrate")] public Data[] Flatrate { get; set; }

    [JsonProperty("ads")] public Data[] Ads { get; set; }

    [JsonProperty("rent")] public Data[] Rent { get; set; }

    [JsonProperty("free")] public Data[] Free { get; set; }
}

public class Data
{
    [JsonProperty("display_priority")] public int DisplayPriority { get; set; }

    [JsonProperty("logo_path")] public string LogoPath { get; set; }

    [JsonProperty("provider_id")] public int ProviderId { get; set; }

    [JsonProperty("provider_name")] public string ProviderName { get; set; }
}