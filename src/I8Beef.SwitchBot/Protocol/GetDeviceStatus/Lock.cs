using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Lock device type.
    /// </summary>
    public class Lock : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Lock;

        /// <summary>
        /// Determines if locked or not.
        /// </summary>
        [JsonProperty(PropertyName = "lockState")]
        public string LockState { get; set; }

        /// <summary>
        /// Determines if the door is closed or not.
        /// </summary>
        [JsonProperty(PropertyName = "doorState")]
        public string DoorState { get; set; }

        /// <summary>
        /// Determines if Lock has been calibrated or not.
        /// </summary>
        [JsonProperty(PropertyName = "calibrate")]
        public bool Calibrate { get; set; }
    }
}
