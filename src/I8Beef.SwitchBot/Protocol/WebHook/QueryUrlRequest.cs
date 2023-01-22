using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.WebHook
{
    /// <summary>
    /// Query url request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class QueryUrlRequest
    {
        /// <summary>
        /// The type of actions.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; } = "queryUrl";
    }
}
