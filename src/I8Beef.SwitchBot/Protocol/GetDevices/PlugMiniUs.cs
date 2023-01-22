namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Plug Mini (US) device type.
    /// </summary>
    public class PlugMiniUs : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.PlugMiniUs;
    }
}
