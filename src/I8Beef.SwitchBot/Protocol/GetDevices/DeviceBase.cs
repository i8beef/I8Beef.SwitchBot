using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Device.
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
        /// Device name.
        /// </summary>
        [JsonProperty(PropertyName = "deviceName")]
        public string DeviceName { get; set; }

        /// <summary>
        /// Device type.
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public abstract string DeviceType { get; set; }

        /// <summary>
        /// Enable cloud service.
        /// </summary>
        [JsonProperty(PropertyName = "enableCloudService")]
        public bool EnableCloudService { get; set; }

        /// <summary>
        /// Hub device ID.
        /// </summary>
        [JsonProperty(PropertyName = "hubDeviceId")]
        public string HubDeviceId { get; set; }
    }
}
