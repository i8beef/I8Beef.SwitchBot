namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Contact Sensor device type.
    /// </summary>
    public class ContactSensor : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.ContactSensor;
    }
}
