using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Meter Plus device type.
    /// </summary>
    public class MeterPlus : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.MeterPlus;

        /// <summary>
        /// Temperature in celsius.
        /// </summary>
        [JsonProperty(PropertyName = "temperature")]
        public decimal Temperature { get; set; }

        /// <summary>
        /// Humidity percentage.
        /// </summary>
        [JsonProperty(PropertyName = "humidity")]
        public int Humidity { get; set; }
    }
}
