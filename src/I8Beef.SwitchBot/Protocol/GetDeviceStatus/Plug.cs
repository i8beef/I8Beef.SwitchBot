namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Plug device type.
    /// </summary>
    public class Plug : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Plug;
    }
}
