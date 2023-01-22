using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Lock device type.
    /// </summary>
    public class Lock : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Lock;

        /// <summary>
        /// Determines if a Lock is grouped with another Lock or not.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public bool Group { get; set; }

        /// <summary>
        /// Determines if a Lock is the master device or not when grouped with another Lock in Dual Lock mode.
        /// </summary>
        [JsonProperty(PropertyName = "master")]
        public bool Master { get; set; }

        /// <summary>
        /// The name of the Lock group.
        /// </summary>
        [JsonProperty(PropertyName = "groupName")]
        public bool GroupName { get; set; }

        /// <summary>
        /// A list of Lock device IDs such that the Lock devices are being grouped in Dual Lock mode.
        /// </summary>
        [JsonProperty(PropertyName = "lockDevicesIds")]
        public IList<string> LockDevicesIds { get; set; }
    }
}
