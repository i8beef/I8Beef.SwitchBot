namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Generic device device type.
    /// </summary>
    public class GenericDevice : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = "Unknown";
    }
}
