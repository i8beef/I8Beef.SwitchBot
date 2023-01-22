using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// KeyList item.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class KeyListItem
    {
        /// <summary>
        /// Passcode ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the passcode.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Type of the passcode. permanent, a permanent passcode. timeLimit, a temporary passcode. disposable, a one-time passcode. urgent, an emergency passcode.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The passcode string encrypted with the developer secret key using the aes-128-cbc algorithm
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// An arbitrary number used for the encryption.
        /// </summary>
        [JsonProperty(PropertyName = "iv")]
        public string Iv { get; set; }

        /// <summary>
        /// The time when the passcode is generated.
        /// </summary>
        [JsonProperty(PropertyName = "createTime")]
        public long CreateTime { get; set; }
    }
}
