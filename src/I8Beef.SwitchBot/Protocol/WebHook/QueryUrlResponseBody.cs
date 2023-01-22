using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.WebHook
{
    /// <summary>
    /// Query url response body.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class QueryUrlResponseBody
    {
        /// <summary>
        /// The URLs.
        /// </summary>
        [JsonProperty(PropertyName = "urls")]
        public IList<string> Urls { get; set; }
    }
}
