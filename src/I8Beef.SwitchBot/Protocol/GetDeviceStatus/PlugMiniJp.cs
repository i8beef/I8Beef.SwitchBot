using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Plug Mini (JP) device type.
    /// </summary>
    public class PlugMiniJp : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.PlugMiniJp;

        /// <summary>
        /// The voltage of the device, measured in Volt.
        /// </summary>
        [JsonProperty(PropertyName = "voltage")]
        public decimal Voltage { get; set; }

        /// <summary>
        /// The voltage of the device, measured in Volt.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// The duration that the device has been used during a day, measured in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "electricityOfDay")]
        public int ElectricityOfDay { get; set; }

        /// <summary>
        /// The current of the device at the moment, measured in Amp.
        /// </summary>
        [JsonProperty(PropertyName = "electricCurrent")]
        public decimal ElectricCurrent { get; set; }
    }
}
