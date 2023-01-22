namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Bot device type.
    /// </summary>
    public class Bot : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Bot;
    }
}
