namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Indoor Cam device type.
    /// </summary>
    public class IndoorCam : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.IndoorCam;
    }
}
