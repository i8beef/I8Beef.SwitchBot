using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.WebHook
{
    /// <summary>
    /// Setup web hook request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SetupWebHookRequest
    {
        /// <summary>
        /// The type of actions.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; } = "setupWebhook";

        /// <summary>
        /// The url where all the events are sent to.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// The list of device ids, currently only supports "ALL"
        /// </summary>
        [JsonProperty(PropertyName = "deviceList")]
        public string DeviceList { get; set; }
    }
}
