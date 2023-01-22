namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Hub Plus device type.
    /// </summary>
    public class HubPlus : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.HubPlus;
    }
}
