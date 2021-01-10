using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Untappd.Net
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

    public class Meta
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("response_time")]
        public ResponseTime ResponseTime { get; set; }

        [JsonProperty("init_time")]
        public InitTime InitTime { get; set; }
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

    public class Contact
    {
        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }
    }

    public class Location
    {
        [JsonProperty("brewery_city")]
        public string BreweryCity { get; set; }

        [JsonProperty("brewery_state")]
        public string BreweryState { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }

    public class Brewery
    {
        [JsonProperty("brewery_id")]
        public int BreweryId { get; set; }

        [JsonProperty("brewery_name")]
        public string BreweryName { get; set; }

        [JsonProperty("brewery_slug")]
        public string BrewerySlug { get; set; }

        [JsonProperty("brewery_type")]
        public string BreweryType { get; set; }

        [JsonProperty("brewery_page_url")]
        public string BreweryPageUrl { get; set; }

        [JsonProperty("brewery_label")]
        public string BreweryLabel { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("brewery_active")]
        public int BreweryActive { get; set; }
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

    public class Beer
    {
        [JsonProperty("bid")]
        public int Bid { get; set; }

        [JsonProperty("beer_name")]
        public string BeerName { get; set; }

        [JsonProperty("beer_label")]
        public string BeerLabel { get; set; }

        [JsonProperty("beer_abv")]
        public double BeerAbv { get; set; }

        [JsonProperty("beer_ibu")]
        public int BeerIbu { get; set; }

        [JsonProperty("beer_slug")]
        public string BeerSlug { get; set; }

        [JsonProperty("beer_description")]
        public string BeerDescription { get; set; }

        [JsonProperty("is_in_production")]
        public int IsInProduction { get; set; }

        [JsonProperty("beer_style_id")]
        public int BeerStyleId { get; set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get; set; }

        [JsonProperty("rating_score")]
        public double RatingScore { get; set; }

        [JsonProperty("rating_count")]
        public int RatingCount { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("beer_active")]
        public int BeerActive { get; set; }

        [JsonProperty("on_list")]
        public bool OnList { get; set; }

        [JsonProperty("has_had")]
        public bool HasHad { get; set; }

        [JsonProperty("auth_rating")]
        public int AuthRating { get; set; }

        [JsonProperty("wish_list")]
        public bool WishList { get; set; }

        [JsonProperty("beer_label_hd")]
        public string BeerLabelHd { get; set; }

        [JsonProperty("is_homebrew")]
        public int IsHomebrew { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get; set; }

        [JsonProperty("media")]
        public ListResult<Item> Media { get; set; }

        [JsonProperty("checkins")]
        public Checkins Checkins { get; set; }

        [JsonProperty("similar")]
        public Similar Similar { get; set; }

        [JsonProperty("friends")]
        public ListResult<Item> Friends { get; set; }

        [JsonProperty("weighted_rating_score")]
        public double WeightedRatingScore { get; set; }

        [JsonProperty("vintages")]
        public ListResult<Item> Vintages { get; set; }

        [JsonProperty("brewed_by")]
        public ListResult<Item> BrewedBy { get; set; }
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

    public class Item
    {
        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }

        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("checkin_id")]
        public int CheckinId { get; set; }

        [JsonProperty("beer")]
        public Beer Beer { get; set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("venue")]
        public List<object> Venue { get; set; }

        [JsonProperty("comment_id")]
        public int CommentId { get; set; }

        [JsonProperty("comment_owner")]
        public bool CommentOwner { get; set; }

        [JsonProperty("comment_editor")]
        public bool CommentEditor { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("comment_source")]
        public string CommentSource { get; set; }

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("like_id")]
        public int LikeId { get; set; }

        [JsonProperty("like_owner")]
        public bool LikeOwner { get; set; }

        [JsonProperty("badge_id")]
        public int BadgeId { get; set; }

        [JsonProperty("user_badge_id")]
        public int UserBadgeId { get; set; }

        [JsonProperty("badge_name")]
        public string BadgeName { get; set; }

        [JsonProperty("badge_description")]
        public string BadgeDescription { get; set; }

        [JsonProperty("badge_image")]
        public BadgeImage BadgeImage { get; set; }

        [JsonProperty("checkin_comment")]
        public string CheckinComment { get; set; }

        [JsonProperty("rating_score")]
        public double RatingScore { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("toasts")]
        public Toasts Toasts { get; set; }

        [JsonProperty("media")]
        public ListResult<Item> Media { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("badges")]
        public Badges Badges { get; set; }

        [JsonProperty("friends")]
        public ListResult<Item> Friends { get; set; }
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
}
