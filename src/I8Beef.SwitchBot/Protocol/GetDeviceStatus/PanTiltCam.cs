namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Pan/Tilt Cam device type.
    /// </summary>
    public class PanTiltCam : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.PanTiltCam;
    }
}
