using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Humidifier device type.
    /// </summary>
    public class Humidifier : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Humidifier;

        /// <summary>
        /// ON/OFF state.
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public string Power { get; set; }

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

        /// <summary>
        /// Atomization efficiency percentage.
        /// </summary>
        [JsonProperty(PropertyName = "nebulizationEfficiency")]
        public int NebulizationEfficiency { get; set; }

        /// <summary>
        /// Determines if a Humidifier is in Auto Mode or not.
        /// </summary>
        [JsonProperty(PropertyName = "auto")]
        public bool Auto { get; set; }

        /// <summary>
        /// Determines if a Humidifier's safety lock is on or not.
        /// </summary>
        [JsonProperty(PropertyName = "childLock")]
        public bool ChildLock { get; set; }

        /// <summary>
        /// Determines if a Humidifier is muted or not.
        /// </summary>
        [JsonProperty(PropertyName = "sound")]
        public bool Sound { get; set; }

        /// <summary>
        /// Determines if the water tank is empty or not.
        /// </summary>
        [JsonProperty(PropertyName = "lackWater")]
        public bool LackWater { get; set; }
    }
}
