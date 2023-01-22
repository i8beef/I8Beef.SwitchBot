namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Ceiling Light device type.
    /// </summary>
    public class CeilingLight : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.CeilingLight;
    }
}
