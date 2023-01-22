using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Ceiling Light Pro device type.
    /// </summary>
    public class CeilingLightPro : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.CeilingLightPro;

        /// <summary>
        /// ON/OFF state.
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public string Power { get; set; }

        /// <summary>
        /// The brightness value, range from 1 to 100.
        /// </summary>
        [JsonProperty(PropertyName = "brightness")]
        public int Brightness { get; set; }

        /// <summary>
        /// The color temperature value, range from 2700 to 6500.
        /// </summary>
        [JsonProperty(PropertyName = "colorTemperature")]
        public int ColorTemperature { get; set; }
    }
}
