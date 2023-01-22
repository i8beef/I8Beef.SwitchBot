using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Meter device type.
    /// </summary>
    public class Meter : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Meter;

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
