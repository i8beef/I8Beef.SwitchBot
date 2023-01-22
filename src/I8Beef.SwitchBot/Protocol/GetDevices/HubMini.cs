namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Hub Mini device type.
    /// </summary>
    public class HubMini : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.HubMini;
    }
}
