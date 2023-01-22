using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Keypad Touch device type.
    /// </summary>
    public class KeypadTouch : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.KeypadTouch;

        /// <summary>
        /// MAC address of the Lock that the current device is paired with.
        /// </summary>
        [JsonProperty(PropertyName = "lockDeviceId")]
        public string LockDeviceIdp { get; set; }

        /// <summary>
        /// A list of passcodes.
        /// </summary>
        [JsonProperty(PropertyName = "keyList")]
        public IList<KeyListItem> KeyList { get; set; }
    }
}
