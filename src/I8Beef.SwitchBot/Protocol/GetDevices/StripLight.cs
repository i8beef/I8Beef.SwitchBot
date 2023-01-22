namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Strip Light device type.
    /// </summary>
    public class StripLight : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.StripLight;
    }
}
