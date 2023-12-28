using System.Diagnostics;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.WebUtilities;
using NoMercy.TMDBApi.Properties;

namespace NoMercy.TMDBApi.Client
{
    public class BaseClient
    {
        private readonly Uri _baseUrl = new("https://api.themoviedb.org/3/");
        private readonly HttpClient _client = new();

        private readonly Dictionary<string, string> _defaultQuery = new();
        public Uri? Uri;

        public BaseClient()
        {
            _client.BaseAddress = _baseUrl;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected BaseClient(int id)
        {
            _client = new HttpClient
            {
                BaseAddress = _baseUrl
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Id = id;
        }

        public BaseClient(Uri uri)
        {
            Uri = uri;
            _client.BaseAddress = _baseUrl;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public BaseClient(HttpClient client, Uri uri)
        {
            _client = client;
            _client.BaseAddress = _baseUrl;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Uri = uri;
        }

        private string ApiKey => Resources.TmdbApiKey;

        protected int Id { get; set; }

        protected async Task<string> Get(string url, Dictionary<string, string>? query = null)
        {
            query ??= _defaultQuery;
            query["api_key"] = ApiKey;

            var newUrl = QueryHelpers.AddQueryString(url, query);

            var response = await _client.GetAsync(newUrl);

            try
            {
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

                return "";
            }
        }
    }
}