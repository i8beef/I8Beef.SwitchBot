using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Contact Sensor device type.
    /// </summary>
    public class ContactSensor : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.ContactSensor;

        /// <summary>
        /// Determines if motion is detected.
        /// </summary>
        [JsonProperty(PropertyName = "moveDetected")]
        public bool MotionDetected { get; set; }

        /// <summary>
        /// The open state of the sensor. open, close, or timeOutNotClose
        /// </summary>
        [JsonProperty(PropertyName = "openState")]
        public string OpenState { get; set; }

        /// <summary>
        /// The ambient brightness picked up by the sensor. bright or dim
        /// </summary>
        [JsonProperty(PropertyName = "brightness")]
        public string Brightness { get; set; }
    }
}
