using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Curtain device type.
    /// </summary>
    public class Curtain : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Curtain;

        /// <summary>
        /// A list of Curtain device IDs such that the Curtain devices are being paired or grouped.
        /// </summary>
        public IList<string> CurtainDevicesIds { get; set; }

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
        /// Determines if a Curtain is the master device or not when paired with or grouped with another Curtain.
        /// </summary>
        [JsonProperty(PropertyName = "master")]
        public bool Master { get; set; }

        /// <summary>
        /// The opening direction of a Curtain.
        /// </summary>
        [JsonProperty(PropertyName = "openDirection")]
        public string OpenDirection { get; set; }
    }
}
