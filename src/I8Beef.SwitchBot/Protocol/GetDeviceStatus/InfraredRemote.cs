using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Infrared remote.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InfraredRemote
    {
        /// <summary>
        /// Device ID.
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Device name.
        /// </summary>
        [JsonProperty(PropertyName = "deviceName")]
        public string DeviceName { get; set; }

        /// <summary>
        /// Remote type.
        /// </summary>
        [JsonProperty(PropertyName = "remoteType")]
        public string RemoteType { get; set; }

        /// <summary>
        /// Hub device ID.
        /// </summary>
        [JsonProperty(PropertyName = "hubDeviceId")]
        public string HubDeviceId { get; set; }
    }
}
