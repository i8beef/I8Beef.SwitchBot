namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Motion Sensor device type.
    /// </summary>
    public class MotionSensor : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.MotionSensor;
    }
}
