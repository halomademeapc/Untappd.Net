using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Untappd.Client
{
    public class ResponseTime
    {
        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }
    }

    public class InitTime
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }
    }

    public class Stats
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("monthly_count")]
        public int MonthlyCount { get; set; }

        [JsonProperty("total_user_count")]
        public int TotalUserCount { get; set; }

        [JsonProperty("user_count")]
        public int UserCount { get; set; }
    }

    public class Photo
    {
        [JsonProperty("photo_img_sm")]
        public string Small { get; set; }

        [JsonProperty("photo_img_md")]
        public string Medium { get; set; }

        [JsonProperty("photo_img_lg")]
        public string Large { get; set; }

        [JsonProperty("photo_img_og")]
        public string Original { get; set; }
    }

    public class User
    {
        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_avatar")]
        public string UserAvatar { get; set; }

        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_supporter")]
        public int IsSupporter { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("relationship")]
        public object Relationship { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("venue_details")]
        public List<object> VenueDetails { get; set; }

        [JsonProperty("brewery_details")]
        public List<object> BreweryDetails { get; set; }
    }

    public class Comments : ListResult<Item>
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class Toasts : ListResult<Item>
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("auth_toast")]
        public bool? AuthToast { get; set; }
    }

    public class Source
    {
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        [JsonProperty("app_website")]
        public string AppWebsite { get; set; }
    }

    public class BadgeImage
    {
        [JsonProperty("sm")]
        public string Small { get; set; }

        [JsonProperty("md")]
        public string Medium { get; set; }

        [JsonProperty("lg")]
        public string Large { get; set; }
    }

    public class Badges : ListResult<Item>
    {
        [JsonProperty("retro_status")]
        public bool RetroStatus { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("since_url")]
        public string SinceUrl { get; set; }

        [JsonProperty("next_url")]
        public string NextUrl { get; set; }

        [JsonProperty("max_id")]
        public int MaxId { get; set; }
    }

    public class Checkins : ListResult<Item>
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Similar : ListResult<Item>
    {
        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class UntappdResponse<TResponse>
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("notifications")]
        public List<object> Notifications { get; set; }

        [JsonProperty("response")]
        public TResponse Response { get; set; }
    }

    public class ListResult<TItem>
    {
        [JsonProperty("items")]
        public List<TItem> Items { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("response_time")]
        public Time ResponseTime { get; set; }

        [JsonProperty("init_time")]
        public Time InitTime { get; set; }
    }

    public partial class Time
    {
        [JsonProperty("time")]
        public double TimeTime { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }
    }

    public partial class BeerSearchResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("time_taken")]
        public double TimeTaken { get; set; }

        [JsonProperty("brewery_id")]
        public long BreweryId { get; set; }

        [JsonProperty("search_type")]
        public string SearchType { get; set; }

        [JsonProperty("type_id")]
        public long TypeId { get; set; }

        [JsonProperty("search_version")]
        public long SearchVersion { get; set; }

        [JsonProperty("found")]
        public long Found { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("parsed_term")]
        public string ParsedTerm { get; set; }

        [JsonProperty("beers")]
        public Beers Beers { get; set; }

        [JsonProperty("homebrew")]
        public Beers Homebrew { get; set; }

        [JsonProperty("breweries")]
        public Beers Breweries { get; set; }
    }

    public partial class Beers
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("checkin_count")]
        public long CheckinCount { get; set; }

        [JsonProperty("have_had")]
        public bool HaveHad { get; set; }

        [JsonProperty("your_count")]
        public long YourCount { get; set; }

        [JsonProperty("beer")]
        public Beer Beer { get; set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get; set; }
    }

    public partial class Beer
    {
        [JsonProperty("bid")]
        public long Bid { get; set; }

        [JsonProperty("beer_name")]
        public string BeerName { get; set; }

        [JsonProperty("beer_label")]
        public Uri BeerLabel { get; set; }

        [JsonProperty("beer_abv")]
        public double BeerAbv { get; set; }

        [JsonProperty("beer_slug")]
        public string BeerSlug { get; set; }

        [JsonProperty("beer_ibu")]
        public long BeerIbu { get; set; }

        [JsonProperty("beer_description")]
        public string BeerDescription { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get; set; }

        [JsonProperty("in_production")]
        public long InProduction { get; set; }

        [JsonProperty("auth_rating")]
        public long AuthRating { get; set; }

        [JsonProperty("wish_list")]
        public bool WishList { get; set; }
    }

    public partial class Brewery
    {
        [JsonProperty("brewery_id")]
        public long BreweryId { get; set; }

        [JsonProperty("brewery_name")]
        public string BreweryName { get; set; }

        [JsonProperty("brewery_slug")]
        public string BrewerySlug { get; set; }

        [JsonProperty("brewery_page_url")]
        public string BreweryPageUrl { get; set; }

        [JsonProperty("brewery_type")]
        public string BreweryType { get; set; }

        [JsonProperty("brewery_label")]
        public Uri BreweryLabel { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("brewery_active")]
        public long BreweryActive { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("brewery_city")]
        public string BreweryCity { get; set; }

        [JsonProperty("brewery_state")]
        public string BreweryState { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }
}
