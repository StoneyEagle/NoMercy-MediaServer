using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NoMercy.TMDBApi.Helpers;

public static class JsonHelper
{
    public static readonly JsonSerializerSettings Settings = new()
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Formatting = Formatting.Indented,
        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        }
    };

    public static T FromJson<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json, Settings);
    }

    public static string ToJson<T>(this T self)
    {
        return JsonConvert.SerializeObject(self, Settings);
    }
}