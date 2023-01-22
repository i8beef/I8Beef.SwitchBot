using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace I8Beef.SwitchBot.Exceptions
{
    /// <summary>
    /// SwitchBot API general exception.
    /// </summary>
    [Serializable]
    public class ApiException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="response">The API response.</param>
        public ApiException(string response)
            : base(response)
        {
            Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected ApiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        /// <summary>
        /// The API response.
        /// </summary>
        public string Response { get; private set; }

        /// <summary>
        /// GetObjectData performs a custom serialization.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
