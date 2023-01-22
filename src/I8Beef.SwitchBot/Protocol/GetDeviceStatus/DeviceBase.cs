using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Device basic information.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class DeviceBase
    {
        /// <summary>
        /// Device ID.
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Device type.
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public abstract string DeviceType { get; set; }

        /// <summary>
        /// Hub device ID.
        /// </summary>
        [JsonProperty(PropertyName = "hubDeviceId")]
        public string HubDeviceId { get; set; }
    }
}
