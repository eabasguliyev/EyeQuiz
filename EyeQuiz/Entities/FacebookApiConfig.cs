using Newtonsoft.Json;

namespace EyeQuiz.Entities
{
    public class FacebookApiConfig
    {
        [JsonProperty("app_id")]
        public string  AppId { get; set; }

        [JsonProperty("extended_permissions")]
        public string  ExtendedPermissions { get; set; }
    }
}