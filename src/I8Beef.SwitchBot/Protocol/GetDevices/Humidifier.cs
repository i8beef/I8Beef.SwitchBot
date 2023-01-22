namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Humidifier device type.
    /// </summary>
    public class Humidifier : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Humidifier;
    }
}
