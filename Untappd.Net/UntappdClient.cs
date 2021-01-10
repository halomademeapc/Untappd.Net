using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Untappd.Net
{
    public class UntappdClient
    {
        private readonly HttpClient httpClient;
        private readonly UntappdConfig config;

        public UntappdClient(HttpClient httpClient, IOptions<UntappdConfig> options)
        {
            this.httpClient = httpClient;
            config = options.Value;
            this.httpClient.BaseAddress = new Uri(config.BaseUrl);
        }

        private async Task<TResult> GetAsync<TResult>(string path)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, AddAuthorization(path)))
            using (var res = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
            {
                if (!res.IsSuccessStatusCode)
                    throw new HttpRequestException($"Received {res.StatusCode} from GET {path}");
                var @string = await res.Content.ReadAsStringAsync();
                var result = Deserialize<TResult>(await res.Content.ReadAsStreamAsync());
                return result;
            }
        }

        private static TResult Deserialize<TResult>(Stream stream)
        {
            if (stream == default || !stream.CanRead)
                return default;

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                return js.Deserialize<TResult>(jtr);
            }
        }

        private string AddAuthorization(string path)
        {
            var builder = new UriBuilder(new Uri(path, UriKind.Relative));
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["client_id"] = config.ClientId;
            query["client_secret"] = config.ClientSecret;
            builder.Query = query.ToString();
            return builder.ToString();
        }
    }
    public class UntappdConfig
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string BaseUrl { get; set; } = "https://api.untappd.com/v4/";
    }
}
