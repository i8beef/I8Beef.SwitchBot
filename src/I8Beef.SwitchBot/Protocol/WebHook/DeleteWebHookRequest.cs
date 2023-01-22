using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.WebHook
{
    /// <summary>
    /// Delete web hook request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DeleteWebHookRequest
    {
        /// <summary>
        /// The type of actions.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; } = "deleteWebhook";

        /// <summary>
        /// The url where all the events are sent to.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
