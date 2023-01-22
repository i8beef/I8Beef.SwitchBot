namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Ceiling Light Pro device type.
    /// </summary>
    public class CeilingLightPro : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.CeilingLightPro;
    }
}
