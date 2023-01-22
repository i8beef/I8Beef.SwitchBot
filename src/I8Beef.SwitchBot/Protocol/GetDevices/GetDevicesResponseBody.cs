using System.Collections.Generic;
using I8Beef.SwitchBot.JsonConverters;
using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// GetDevices response body.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GetDevicesResponseBody
    {
        /// <summary>
        /// Device list.
        /// </summary>
        [JsonProperty(PropertyName = "deviceList", ItemConverterType = typeof(DeviceTypeJsonConverter))]
        public IList<DeviceBase> DeviceList { get; set; }

        /// <summary>
        /// Infrared remote list..
        /// </summary>
        [JsonProperty(PropertyName = "infraredRemoteList")]
        public IList<InfraredRemote> InfraredRemoteList { get; set; }
    }
}
