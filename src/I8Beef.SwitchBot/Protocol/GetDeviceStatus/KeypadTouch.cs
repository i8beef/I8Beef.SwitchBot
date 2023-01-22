namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Keypad Touch device type.
    /// </summary>
    public class KeypadTouch : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.KeypadTouch;
    }
}
