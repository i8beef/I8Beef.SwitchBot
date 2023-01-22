namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Color Bulb device type.
    /// </summary>
    public class ColorBulb : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.ColorBulb;
    }
}
