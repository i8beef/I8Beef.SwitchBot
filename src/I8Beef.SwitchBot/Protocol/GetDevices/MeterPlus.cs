namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Meter Plus device type.
    /// </summary>
    public class MeterPlus : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.MeterPlus;
    }
}
