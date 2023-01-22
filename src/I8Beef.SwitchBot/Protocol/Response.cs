using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol
{
    /// <summary>
    /// Response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Response<TBody>
    {
        /// <summary>
        /// Status code.
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Response body.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public TBody Body { get; set; }
    }
}
