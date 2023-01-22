namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Plug Mini (JP) device type.
    /// </summary>
    public class PlugMiniJp : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.PlugMiniJp;
    }
}
