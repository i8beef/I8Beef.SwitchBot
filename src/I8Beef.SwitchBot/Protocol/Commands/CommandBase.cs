using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.Commands
{
    /// <summary>
    /// Command base.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CommandBase
    {
        /// <summary>
        /// Command type.
        /// </summary>
        [JsonProperty(PropertyName = "commandType")]
        public static string CommandType => "command";

        /// <summary>
        /// Command type.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }

        /// <summary>
        /// Command type.
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public dynamic Parameter { get; set; }
    }
}
