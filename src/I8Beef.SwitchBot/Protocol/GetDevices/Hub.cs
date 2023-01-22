namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Hub device type.
    /// </summary>
    public class Hub : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Hub;
    }
}
