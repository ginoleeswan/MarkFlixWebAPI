namespace MarkFlixWebAPI.Models.Overseerr.Requests
{

    public class GetOverseerrUserRequestsResult
    {
        public Pageinfo pageInfo { get; set; }
        public Result[] results { get; set; }
    }

    public class Pageinfo
    {
        public int pages { get; set; }
        public int pageSize { get; set; }
        public int results { get; set; }
        public int page { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public int status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string type { get; set; }
        public bool is4k { get; set; }
        public int serverId { get; set; }
        public int profileId { get; set; }
        public string rootFolder { get; set; }
        public int? languageProfileId { get; set; }
        public object[] tags { get; set; }
        public Media media { get; set; }
        public Season[] seasons { get; set; }
        public Modifiedby modifiedBy { get; set; }
        public Requestedby requestedBy { get; set; }
        public int seasonCount { get; set; }
    }

    public class Media
    {
        public object[] downloadStatus { get; set; }
        public object[] downloadStatus4k { get; set; }
        public int id { get; set; }
        public string mediaType { get; set; }
        public int tmdbId { get; set; }
        public int? tvdbId { get; set; }
        public object imdbId { get; set; }
        public int status { get; set; }
        public int status4k { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime lastSeasonChange { get; set; }
        public DateTime? mediaAddedAt { get; set; }
        public int serviceId { get; set; }
        public object serviceId4k { get; set; }
        public int externalServiceId { get; set; }
        public object externalServiceId4k { get; set; }
        public string externalServiceSlug { get; set; }
        public object externalServiceSlug4k { get; set; }
        public string ratingKey { get; set; }
        public object ratingKey4k { get; set; }
        public string plexUrl { get; set; }
        public string serviceUrl { get; set; }
    }

    public class Modifiedby
    {
        public int permissions { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string plexUsername { get; set; }
        public object username { get; set; }
        public object recoveryLinkExpirationDate { get; set; }
        public int userType { get; set; }
        public string avatar { get; set; }
        public object movieQuotaLimit { get; set; }
        public object movieQuotaDays { get; set; }
        public object tvQuotaLimit { get; set; }
        public object tvQuotaDays { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int requestCount { get; set; }
        public string displayName { get; set; }
    }

    public class Requestedby
    {
        public int permissions { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string plexUsername { get; set; }
        public object username { get; set; }
        public object recoveryLinkExpirationDate { get; set; }
        public int userType { get; set; }
        public string avatar { get; set; }
        public object movieQuotaLimit { get; set; }
        public object movieQuotaDays { get; set; }
        public object tvQuotaLimit { get; set; }
        public object tvQuotaDays { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int requestCount { get; set; }
        public string displayName { get; set; }
    }

    public class Season
    {
        public int id { get; set; }
        public int seasonNumber { get; set; }
        public int status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

}
