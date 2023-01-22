namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Remote device type.
    /// </summary>
    public class Remote : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.Remote;
    }
}
