namespace I8Beef.SwitchBot.Protocol.GetDevices
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
