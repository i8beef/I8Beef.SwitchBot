using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.WebHook
{
    /// <summary>
    /// Query details request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class QueryDetailsRequest
    {
        /// <summary>
        /// The type of actions.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; } = "queryDetails";

        /// <summary>
        /// The URLs.
        /// </summary>
        [JsonProperty(PropertyName = "urls")]
        public IList<string> Urls { get; set; }
    }
}
