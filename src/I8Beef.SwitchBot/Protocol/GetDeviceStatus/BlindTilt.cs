using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Blind Tilt device type.
    /// </summary>
    public class BlindTilt : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.BlindTilt;

        /// <summary>
        /// A list of Blind Tilt device IDs such that the Blind Tilt devices are being paired or grouped.
        /// </summary>
        [JsonProperty(PropertyName = "blindTiltDevicesIds")]
        public IList<string> BlindTiltDevicesIds { get; set; }

        /// <summary>
        /// Determines if the open and the closed positions have been properly calibrated or not.
        /// </summary>
        [JsonProperty(PropertyName = "calibrate")]
        public bool Calibrate { get; set; }

        /// <summary>
        /// Determines if a Blind Tilt device is paired with or grouped with one or more devices of the same type or not.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public bool Group { get; set; }

        /// <summary>
        /// Determines if a Blind Tilt device is the master device or not when paired with or grouped with one or more devices of the same type.
        /// </summary>
        [JsonProperty(PropertyName = "master")]
        public bool Master { get; set; }

        /// <summary>
        /// The opening direction of a Blind Tilt device.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

        /// <summary>
        /// The current position, 0-100.
        /// </summary>
        [JsonProperty(PropertyName = "slidePosition")]
        public int SlidePosition { get; set; }

        /// <summary>
        /// The version of the device
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }
    }
}
