namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Meter device type.
    /// </summary>
    public class Meter : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Meter;
    }
}
