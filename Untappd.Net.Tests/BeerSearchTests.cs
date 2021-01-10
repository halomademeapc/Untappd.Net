using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Untappd.Client.Tests
{
    public class BeerSearchTests
    {
        private readonly UntappdClient client;

        public BeerSearchTests()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<BeerSearchTests>().Build();
            client = new UntappdClient(new HttpClient(), Options.Create(new UntappdConfig
            {
                ClientId = config.GetValue<string>("Id"),
                ClientSecret = config.GetValue<string>("Secret")
            }));
        }

        [Fact]
        public async Task Gets_Beers()
        {
            var result = await client.SearchBeers("Pliny");
            Assert.NotEmpty(result.Response.Beers.Items);
        }
    }
}
