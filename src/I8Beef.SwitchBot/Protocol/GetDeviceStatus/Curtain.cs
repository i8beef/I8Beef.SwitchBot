using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Curtain device type.
    /// </summary>
    public class Curtain : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Curtain;

        /// <summary>
        /// Determines if the open position and the close position of a device have been properly calibrated or not.
        /// </summary>
        [JsonProperty(PropertyName = "calibrate")]
        public bool Calibrate { get; set; }

        /// <summary>
        /// Determines if a Curtain is paired with or grouped with another Curtain or not.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public bool Group { get; set; }

        /// <summary>
        /// Determines if a Curtain is moving or not.
        /// </summary>
        [JsonProperty(PropertyName = "moving")]
        public bool Moving { get; set; }

        /// <summary>
        /// The percentage of the distance between the calibrated open position and closed position that Curtain has traversed.
        /// </summary>
        [JsonProperty(PropertyName = "slidePosition")]
        public string SlidePosition { get; set; }
    }
}
