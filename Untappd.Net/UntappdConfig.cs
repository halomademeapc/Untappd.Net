namespace Untappd.Client
{
    public class UntappdConfig
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string BaseUrl { get; set; } = "https://api.untappd.com/v4/";
    }
}
