using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Companies;

public class CompanyDetails
{

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("headquarters")] public string? Headquarters { get; set; }

    [JsonProperty("homepage")] public Uri? Homepage { get; set; }

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("logo_path")] public string? LogoPath { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("origin_country")] public string? OriginCountry { get; set; }

    [JsonProperty("parent_company")] public ParentCompany? ParentCompany { get; set; }
}

public class ParentCompany
{
    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("logo_path")] public string? LogoPath { get; set; }
}