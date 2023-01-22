using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.WebHook
{
    /// <summary>
    /// WebHook details.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class WebHookDetails
    {
        /// <summary>
        /// The url where all the events are sent to.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// The created time.
        /// </summary>
        [JsonProperty(PropertyName = "createTime")]
        public long CreateTime { get; set; }

        /// <summary>
        /// The last updated time.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public long LastUpdateTime { get; set; }

        /// <summary>
        /// The list of device ids, currently only supports "ALL".
        /// </summary>
        [JsonProperty(PropertyName = "deviceList")]
        public string DeviceList { get; set; }

        /// <summary>
        /// Determines if the web hook is enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool Enable { get; set; }
    }
}
